namespace FireAlarm
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
            this.btnFireAlarm = new System.Windows.Forms.Button();
            this.rbtnMinor = new System.Windows.Forms.RadioButton();
            this.rbtnSerious = new System.Windows.Forms.RadioButton();
            this.rbtnInferno = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnFireAlarm
            // 
            this.btnFireAlarm.Location = new System.Drawing.Point(29, 32);
            this.btnFireAlarm.Name = "btnFireAlarm";
            this.btnFireAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnFireAlarm.TabIndex = 0;
            this.btnFireAlarm.Text = "FireAlarm";
            this.btnFireAlarm.UseVisualStyleBackColor = true;
            this.btnFireAlarm.Click += new System.EventHandler(this.btnFireAlarm_Click);
            // 
            // rbtnMinor
            // 
            this.rbtnMinor.AutoSize = true;
            this.rbtnMinor.Checked = true;
            this.rbtnMinor.Location = new System.Drawing.Point(29, 61);
            this.rbtnMinor.Name = "rbtnMinor";
            this.rbtnMinor.Size = new System.Drawing.Size(51, 17);
            this.rbtnMinor.TabIndex = 1;
            this.rbtnMinor.TabStop = true;
            this.rbtnMinor.Text = "Minor";
            this.rbtnMinor.UseVisualStyleBackColor = true;
            // 
            // rbtnSerious
            // 
            this.rbtnSerious.AutoSize = true;
            this.rbtnSerious.Location = new System.Drawing.Point(29, 84);
            this.rbtnSerious.Name = "rbtnSerious";
            this.rbtnSerious.Size = new System.Drawing.Size(60, 17);
            this.rbtnSerious.TabIndex = 2;
            this.rbtnSerious.TabStop = true;
            this.rbtnSerious.Text = "Serious";
            this.rbtnSerious.UseVisualStyleBackColor = true;
            // 
            // rbtnInferno
            // 
            this.rbtnInferno.AutoSize = true;
            this.rbtnInferno.Location = new System.Drawing.Point(29, 107);
            this.rbtnInferno.Name = "rbtnInferno";
            this.rbtnInferno.Size = new System.Drawing.Size(58, 17);
            this.rbtnInferno.TabIndex = 3;
            this.rbtnInferno.TabStop = true;
            this.rbtnInferno.Text = "Inferno";
            this.rbtnInferno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 358);
            this.Controls.Add(this.rbtnInferno);
            this.Controls.Add(this.rbtnSerious);
            this.Controls.Add(this.rbtnMinor);
            this.Controls.Add(this.btnFireAlarm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFireAlarm;
        private System.Windows.Forms.RadioButton rbtnMinor;
        private System.Windows.Forms.RadioButton rbtnSerious;
        private System.Windows.Forms.RadioButton rbtnInferno;
    }
}

