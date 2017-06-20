namespace howto_hexagonal_grid
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            picGrid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            SuspendLayout();
            // 
            // picGrid
            // 
            picGrid.Anchor = System.Windows.Forms.AnchorStyles.Top
                             | System.Windows.Forms.AnchorStyles.Bottom
                             | System.Windows.Forms.AnchorStyles.Left
                             | System.Windows.Forms.AnchorStyles.Right;
            picGrid.BackColor = System.Drawing.Color.White;
            picGrid.Location = new System.Drawing.Point(12, 12);
            picGrid.Name = "picGrid";
            picGrid.Size = new System.Drawing.Size(260, 237);
            picGrid.TabIndex = 1;
            picGrid.TabStop = false;
            picGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(PicGrid_MouseMove);
            picGrid.Resize += new System.EventHandler(PicGrid_Resize);
            picGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(PicGrid_MouseClick);
            picGrid.Paint += new System.Windows.Forms.PaintEventHandler(PicGrid_Paint);
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(284, 261);
            Controls.Add(picGrid);
            Name = "Form1";
            Text = "howto_hexagonal_grid";
            ((System.ComponentModel.ISupportInitialize)picGrid).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGrid;
    }
}

