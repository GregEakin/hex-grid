using System.ComponentModel;

namespace HexagonalGrid;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private IContainer _components = null;

    private PictureBox _pictureBox = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (_components != null))
        {
            _components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        _components = new System.ComponentModel.Container();

        _pictureBox = new PictureBox();
        ((ISupportInitialize)(_pictureBox)).BeginInit();
        SuspendLayout();

        // 
        // pictureBox
        // 
        _pictureBox.Anchor = AnchorStyles.Top
                             | AnchorStyles.Bottom
                             | AnchorStyles.Left
                             | AnchorStyles.Right;
        _pictureBox.BackColor = Color.White;
        _pictureBox.Location = new Point(12, 12);
        _pictureBox.Name = "_pictureBox";
        _pictureBox.Size = new Size(260, 237);
        _pictureBox.TabIndex = 1;
        _pictureBox.TabStop = false;
        _pictureBox.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
        _pictureBox.Resize += new System.EventHandler(PictureBox_Resize);
        _pictureBox.MouseClick += new MouseEventHandler(PictureBox_MouseClick);
        _pictureBox.Paint += new PaintEventHandler(PictureBox_Paint);

        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(6.0f, 13.0f);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(284, 261);
        Controls.Add(_pictureBox);
        Name = "Form1";
        Text = "Hexagonal Grid";

        ((ISupportInitialize)_pictureBox).EndInit();
        ResumeLayout(false);
    }

    #endregion
}
