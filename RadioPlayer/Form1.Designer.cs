namespace RadioPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radio1Button = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.radio2Button = new System.Windows.Forms.Button();
            this.radio3Button = new System.Windows.Forms.Button();
            this.radio4Button = new System.Windows.Forms.Button();
            this.radio5Button = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // radio1Button
            // 
            this.radio1Button.Location = new System.Drawing.Point(520, 780);
            this.radio1Button.Name = "radio1Button";
            this.radio1Button.Size = new System.Drawing.Size(140, 98);
            this.radio1Button.TabIndex = 0;
            this.radio1Button.Text = "Radio 1";
            this.radio1Button.UseVisualStyleBackColor = true;
            this.radio1Button.Click += new System.EventHandler(this.radio1Button_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(342, 38);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1260, 703);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // radio2Button
            // 
            this.radio2Button.Location = new System.Drawing.Point(712, 780);
            this.radio2Button.Name = "radio2Button";
            this.radio2Button.Size = new System.Drawing.Size(131, 98);
            this.radio2Button.TabIndex = 2;
            this.radio2Button.Text = "Radio 2";
            this.radio2Button.UseVisualStyleBackColor = true;
            this.radio2Button.Click += new System.EventHandler(this.radio2Button_Click);
            // 
            // radio3Button
            // 
            this.radio3Button.Location = new System.Drawing.Point(905, 780);
            this.radio3Button.Name = "radio3Button";
            this.radio3Button.Size = new System.Drawing.Size(131, 98);
            this.radio3Button.TabIndex = 3;
            this.radio3Button.Text = "Radio 3";
            this.radio3Button.UseVisualStyleBackColor = true;
            this.radio3Button.Click += new System.EventHandler(this.radio3Button_Click);
            // 
            // radio4Button
            // 
            this.radio4Button.Location = new System.Drawing.Point(1080, 780);
            this.radio4Button.Name = "radio4Button";
            this.radio4Button.Size = new System.Drawing.Size(131, 98);
            this.radio4Button.TabIndex = 4;
            this.radio4Button.Text = "Radio 4";
            this.radio4Button.UseVisualStyleBackColor = true;
            this.radio4Button.Click += new System.EventHandler(this.radio4Button_Click);
            // 
            // radio5Button
            // 
            this.radio5Button.Location = new System.Drawing.Point(1253, 780);
            this.radio5Button.Name = "radio5Button";
            this.radio5Button.Size = new System.Drawing.Size(131, 98);
            this.radio5Button.TabIndex = 5;
            this.radio5Button.Text = "Radio 5";
            this.radio5Button.UseVisualStyleBackColor = true;
            this.radio5Button.Click += new System.EventHandler(this.radio5Button_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(520, 899);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(864, 71);
            this.openFileButton.TabIndex = 6;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 989);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.radio5Button);
            this.Controls.Add(this.radio4Button);
            this.Controls.Add(this.radio3Button);
            this.Controls.Add(this.radio2Button);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.radio1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button radio1Button;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button radio2Button;
        private System.Windows.Forms.Button radio3Button;
        private System.Windows.Forms.Button radio4Button;
        private System.Windows.Forms.Button radio5Button;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

