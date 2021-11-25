#define FIG1
#define FIG34

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace howto_hexagonal_grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const float HexHeight = 50;

        private readonly List<PointF> _hexagons = new List<PointF>();

#if FIG34
        private readonly List<RectangleF> _testRects = new List<RectangleF>();
#endif

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (var point in _hexagons)
            {
                var points = HexToPoints(HexHeight, point.X, point.Y);
                e.Graphics.FillPolygon(Brushes.LightBlue, points);
            }

            DrawHexGrid(e.Graphics, Pens.Black,
                0, pictureBox.ClientSize.Width,
                0, pictureBox.ClientSize.Height,
                HexHeight);

#if FIG34
            using (var pen = new Pen(Color.Red, 3))
            {
                pen.DashStyle = DashStyle.Dash;
                foreach (var rect in _testRects)
                    e.Graphics.DrawRectangle(pen, Rectangle.Round(rect));
            }
#endif
        }

        private void DrawHexGrid(Graphics gr, Pen pen,
            float xMin, float xMax, float yMin, float yMax,
            float height)
        {
            for (var row = 0; ; row++)
            {
                var points = HexToPoints(height, row, 0);
                if (points[4].Y > yMax) break;

                for (var col = 0; ; col++)
                {
                    points = HexToPoints(height, row, col);
                    if (points[3].X > xMax) break;
                    if (points[4].Y > yMax) continue;
                    gr.DrawPolygon(pen, points);

#if FIG1
                    using (var sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        var x = (points[0].X + points[3].X) / 2;
                        var y = (points[1].Y + points[4].Y) / 2;
                        var label = $"({row}, {col})";
                        gr.DrawString(label, Font, Brushes.Black, x, y, sf);
                    }
#endif
                }
            }
        }

        private void PictureBox_Resize(object sender, EventArgs e)
        {
            pictureBox.Refresh();
        }

        // Display the row and column under the mouse.
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            PointToHex(e.X, e.Y, HexHeight, out var row, out var col);
            Text = $"({row}, {col})";
        }

        // Add the clicked hexagon to the Hexagons list.
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            PointToHex(e.X, e.Y, HexHeight, out var row, out var col);

            var pointF = new PointF(row, col);
            if (_hexagons.Contains(pointF))
                _hexagons.Remove(pointF);
            else
                _hexagons.Add(pointF);

#if FIG34
            // Used to draw Figures 3 and 4.
            var points = HexToPoints(HexHeight, row, col);
            var x1 = points[0].X;
            var y1 = points[1].Y;
            var x2 = 0.75f * (points[3].X - x1);
            var y2 = points[4].Y - y1;
            var rectangleF = new RectangleF(x1, y1, x2, y2);
            _testRects.Add(rectangleF);
#endif

            pictureBox.Refresh();
        }

        // Return the width of a hexagon.
        private static float HexWidth(float height)
        {
            return (float)(4 * (height / 2 / Math.Sqrt(3)));
        }

        // Return the row and column of the hexagon at this point.
        private static void PointToHex(float x, float y, float height, out int row, out int col)
        {
            // Find the test rectangle containing the point.
            var width = HexWidth(height);
            col = (int)(x / (width * 0.75f));

            if (col % 2 == 0)
                row = (int)(y / height);
            else
                row = (int)((y - height / 2) / height);

            // Find the test area.
            var testX = col * width * 0.75f;
            var testY = row * height;
            if (col % 2 == 1) testY += height / 2;

            // See if the point is above or
            // below the test hexagon on the left.
            bool isAbove = false, isBelow = false;
            var dx = x - testX;
            if (dx < width / 4)
            {
                var dy = y - (testY + height / 2);
                if (dx < 0.001)
                {
                    // The point is on the left edge of the test rectangle.
                    isAbove = dy < 0;
                    isBelow = dy > 0;
                }
                else if (dy < 0)
                {
                    // See if the point is above the test hexagon.
                    isAbove = -dy / dx > Math.Sqrt(3);
                }
                else
                {
                    // See if the point is below the test hexagon.
                    isBelow = dy / dx > Math.Sqrt(3);
                }
            }

            // Adjust the row and column if necessary.
            if (isAbove)
            {
                if (col % 2 == 0) row--;
                col--;
            }
            else if (isBelow)
            {
                if (col % 2 == 1) row++;
                col--;
            }
        }

        private static PointF[] HexToPoints(float height, float row, float col)
        {
            var width = HexWidth(height);

            var x = col * (width * 0.75f);

            var y = height * (row + 0.5f);
            if (col % 2 >= 1) y += height / 2;

            var points = new[]
            {
                new PointF(x, y),
                new PointF(x + width * 0.25f, y - height / 2),
                new PointF(x + width * 0.75f, y - height / 2),
                new PointF(x + width, y),
                new PointF(x + width * 0.75f, y + height / 2),
                new PointF(x + width * 0.25f, y + height / 2),
            };

            return points;
        }
    }
}
