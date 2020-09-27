using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace howto_hexagonal_grid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picGrid = new PictureBox();
            ((ISupportInitialize)(this.picGrid)).BeginInit();
            SuspendLayout();
            // 
            // picGrid
            // 
            picGrid.Anchor = AnchorStyles.Top
                             | AnchorStyles.Bottom
                             | AnchorStyles.Left
                             | AnchorStyles.Right;
            picGrid.BackColor = Color.White;
            picGrid.Location = new Point(12, 12);
            picGrid.Name = "picGrid";
            picGrid.Size = new Size(260, 237);
            picGrid.TabIndex = 1;
            picGrid.TabStop = false;
            picGrid.MouseMove += new MouseEventHandler(PicGrid_MouseMove);
            picGrid.Resize += new System.EventHandler(PicGrid_Resize);
            picGrid.MouseClick += new MouseEventHandler(PicGrid_MouseClick);
            picGrid.Paint += new PaintEventHandler(PicGrid_Paint);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(picGrid);
            Name = "Form1";
            Text = "howto_hexagonal_grid";
            ((ISupportInitialize)picGrid).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private PictureBox picGrid;
    }
}

