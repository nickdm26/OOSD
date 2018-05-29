namespace EncryptionMachine
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecyrpt = new System.Windows.Forms.Button();
            this.txtbInput = new System.Windows.Forms.TextBox();
            this.txtbOuput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.rbtnReverse = new System.Windows.Forms.RadioButton();
            this.rtbnROT13 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(230, 68);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecyrpt
            // 
            this.btnDecyrpt.Location = new System.Drawing.Point(311, 68);
            this.btnDecyrpt.Name = "btnDecyrpt";
            this.btnDecyrpt.Size = new System.Drawing.Size(75, 23);
            this.btnDecyrpt.TabIndex = 1;
            this.btnDecyrpt.Text = "Decyrpt";
            this.btnDecyrpt.UseVisualStyleBackColor = true;
            this.btnDecyrpt.Click += new System.EventHandler(this.btnDecyrpt_Click);
            // 
            // txtbInput
            // 
            this.txtbInput.Location = new System.Drawing.Point(62, 152);
            this.txtbInput.Name = "txtbInput";
            this.txtbInput.Size = new System.Drawing.Size(324, 20);
            this.txtbInput.TabIndex = 2;
            // 
            // txtbOuput
            // 
            this.txtbOuput.Location = new System.Drawing.Point(62, 178);
            this.txtbOuput.Name = "txtbOuput";
            this.txtbOuput.ReadOnly = true;
            this.txtbOuput.Size = new System.Drawing.Size(324, 20);
            this.txtbOuput.TabIndex = 3;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 152);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Input";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 185);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output";
            // 
            // rbtnReverse
            // 
            this.rbtnReverse.AutoSize = true;
            this.rbtnReverse.Checked = true;
            this.rbtnReverse.Location = new System.Drawing.Point(62, 74);
            this.rbtnReverse.Name = "rbtnReverse";
            this.rbtnReverse.Size = new System.Drawing.Size(95, 17);
            this.rbtnReverse.TabIndex = 6;
            this.rbtnReverse.TabStop = true;
            this.rbtnReverse.Text = "String Reverse";
            this.rbtnReverse.UseVisualStyleBackColor = true;
            this.rbtnReverse.CheckedChanged += new System.EventHandler(this.rbtnReverse_CheckedChanged);
            // 
            // rtbnROT13
            // 
            this.rtbnROT13.AutoSize = true;
            this.rtbnROT13.Location = new System.Drawing.Point(62, 98);
            this.rtbnROT13.Name = "rtbnROT13";
            this.rtbnROT13.Size = new System.Drawing.Size(60, 17);
            this.rtbnROT13.TabIndex = 7;
            this.rtbnROT13.Text = "ROT13";
            this.rtbnROT13.UseVisualStyleBackColor = true;
            this.rtbnROT13.CheckedChanged += new System.EventHandler(this.rtbnROT13_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Encryption Algorthim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbnROT13);
            this.Controls.Add(this.rbtnReverse);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtbOuput);
            this.Controls.Add(this.txtbInput);
            this.Controls.Add(this.btnDecyrpt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecyrpt;
        private System.Windows.Forms.TextBox txtbInput;
        private System.Windows.Forms.TextBox txtbOuput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RadioButton rbtnReverse;
        private System.Windows.Forms.RadioButton rtbnROT13;
        private System.Windows.Forms.Label label1;
    }
}

