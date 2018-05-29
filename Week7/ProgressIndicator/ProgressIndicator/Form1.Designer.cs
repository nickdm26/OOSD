namespace ProgressIndicator
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnSpin = new System.Windows.Forms.RadioButton();
            this.rbtnProgress = new System.Windows.Forms.RadioButton();
            this.rbtnTrack = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Slow Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnSpin
            // 
            this.rbtnSpin.AutoSize = true;
            this.rbtnSpin.Checked = true;
            this.rbtnSpin.Location = new System.Drawing.Point(18, 20);
            this.rbtnSpin.Name = "rbtnSpin";
            this.rbtnSpin.Size = new System.Drawing.Size(67, 17);
            this.rbtnSpin.TabIndex = 1;
            this.rbtnSpin.TabStop = true;
            this.rbtnSpin.Text = "Spin Box";
            this.rbtnSpin.UseVisualStyleBackColor = true;
            // 
            // rbtnProgress
            // 
            this.rbtnProgress.AutoSize = true;
            this.rbtnProgress.Location = new System.Drawing.Point(16, 64);
            this.rbtnProgress.Name = "rbtnProgress";
            this.rbtnProgress.Size = new System.Drawing.Size(85, 17);
            this.rbtnProgress.TabIndex = 2;
            this.rbtnProgress.Text = "Progress Bar";
            this.rbtnProgress.UseVisualStyleBackColor = true;
            this.rbtnProgress.CheckedChanged += new System.EventHandler(this.rbtnProgress_CheckedChanged);
            // 
            // rbtnTrack
            // 
            this.rbtnTrack.AutoSize = true;
            this.rbtnTrack.Location = new System.Drawing.Point(18, 110);
            this.rbtnTrack.Name = "rbtnTrack";
            this.rbtnTrack.Size = new System.Drawing.Size(69, 17);
            this.rbtnTrack.TabIndex = 3;
            this.rbtnTrack.Text = "TrackBar";
            this.rbtnTrack.UseVisualStyleBackColor = true;
            this.rbtnTrack.CheckedChanged += new System.EventHandler(this.rbtnTrack_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(172, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(344, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(172, 110);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(344, 45);
            this.trackBar1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(172, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 471);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rbtnTrack);
            this.Controls.Add(this.rbtnProgress);
            this.Controls.Add(this.rbtnSpin);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnSpin;
        private System.Windows.Forms.RadioButton rbtnProgress;
        private System.Windows.Forms.RadioButton rbtnTrack;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
    }
}

