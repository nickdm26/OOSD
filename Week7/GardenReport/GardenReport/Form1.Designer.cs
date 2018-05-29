namespace GardenReport
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
            this.btnAreaReport = new System.Windows.Forms.Button();
            this.btnChargesReport = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAreaReport
            // 
            this.btnAreaReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAreaReport.Location = new System.Drawing.Point(12, 32);
            this.btnAreaReport.Name = "btnAreaReport";
            this.btnAreaReport.Size = new System.Drawing.Size(190, 56);
            this.btnAreaReport.TabIndex = 0;
            this.btnAreaReport.Text = "Area Report";
            this.btnAreaReport.UseVisualStyleBackColor = true;
            this.btnAreaReport.Click += new System.EventHandler(this.btnAreaReport_Click);
            // 
            // btnChargesReport
            // 
            this.btnChargesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChargesReport.Location = new System.Drawing.Point(233, 32);
            this.btnChargesReport.Name = "btnChargesReport";
            this.btnChargesReport.Size = new System.Drawing.Size(190, 56);
            this.btnChargesReport.TabIndex = 1;
            this.btnChargesReport.Text = "Charges Report";
            this.btnChargesReport.UseVisualStyleBackColor = true;
            this.btnChargesReport.Click += new System.EventHandler(this.btnChargesReport_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(411, 292);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 411);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnChargesReport);
            this.Controls.Add(this.btnAreaReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAreaReport;
        private System.Windows.Forms.Button btnChargesReport;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

