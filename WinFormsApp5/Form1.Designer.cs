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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            bUDown = new Button();
            bGreen = new Button();
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(42, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "90°";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 37);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(48, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "180°";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 62);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(48, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "270°";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(12, 87);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 5;
            button1.Text = "Rotate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(12, 116);
            button2.Name = "button2";
            button2.Size = new Size(86, 23);
            button2.TabIndex = 6;
            button2.Text = "Invert Colors";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // bUDown
            // 
            bUDown.BackColor = SystemColors.ActiveCaption;
            bUDown.Location = new Point(12, 145);
            bUDown.Name = "bUDown";
            bUDown.Size = new Size(86, 23);
            bUDown.TabIndex = 7;
            bUDown.Text = "Upside Down";
            bUDown.TextImageRelation = TextImageRelation.TextAboveImage;
            bUDown.UseVisualStyleBackColor = false;
            bUDown.Click += button3_Click;
            // 
            // bGreen
            // 
            bGreen.Location = new Point(12, 174);
            bGreen.Name = "bGreen";
            bGreen.Size = new Size(86, 23);
            bGreen.TabIndex = 8;
            bGreen.Text = "OnlyGreen";
            bGreen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 447);
            Controls.Add(bGreen);
            Controls.Add(bUDown);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Controls.Add(bLoad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bLoad;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private Button button2;
        private Button bUDown;
        private Button bGreen;
    }
}
