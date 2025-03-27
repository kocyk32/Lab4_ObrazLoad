namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bLoad = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bLoad
            // 
            bLoad.Location = new Point(12, 412);
            bLoad.Name = "bLoad";
            bLoad.Size = new Size(86, 23);
            bLoad.TabIndex = 0;
            bLoad.Text = "Load";
            bLoad.UseVisualStyleBackColor = true;
            bLoad.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(117, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 423);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 447);
            Controls.Add(pictureBox1);
            Controls.Add(bLoad);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bLoad;
        private PictureBox pictureBox1;
    }
}
