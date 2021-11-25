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
            pictureBox = new PictureBox();
            ((ISupportInitialize)(this.pictureBox)).BeginInit();
            SuspendLayout();

            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top
                             | AnchorStyles.Bottom
                             | AnchorStyles.Left
                             | AnchorStyles.Right;
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(260, 237);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
            pictureBox.Resize += new System.EventHandler(PictureBox_Resize);
            pictureBox.MouseClick += new MouseEventHandler(PictureBox_MouseClick);
            pictureBox.Paint += new PaintEventHandler(PictureBox_Paint);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "howto_hexagonal_grid";
            ((ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
    }
}

