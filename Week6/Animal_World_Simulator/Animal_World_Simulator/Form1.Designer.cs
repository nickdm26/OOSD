namespace Animal_World_Simulator
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
            this.btnNorthAmerica = new System.Windows.Forms.Button();
            this.btnAustralia = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNorthAmerica
            // 
            this.btnNorthAmerica.Location = new System.Drawing.Point(12, 368);
            this.btnNorthAmerica.Name = "btnNorthAmerica";
            this.btnNorthAmerica.Size = new System.Drawing.Size(130, 23);
            this.btnNorthAmerica.TabIndex = 0;
            this.btnNorthAmerica.Text = "North America";
            this.btnNorthAmerica.UseVisualStyleBackColor = true;
            this.btnNorthAmerica.Click += new System.EventHandler(this.btnNorthAmerica_Click);
            // 
            // btnAustralia
            // 
            this.btnAustralia.Location = new System.Drawing.Point(255, 368);
            this.btnAustralia.Name = "btnAustralia";
            this.btnAustralia.Size = new System.Drawing.Size(130, 23);
            this.btnAustralia.TabIndex = 1;
            this.btnAustralia.Text = "Australia";
            this.btnAustralia.UseVisualStyleBackColor = true;
            this.btnAustralia.Click += new System.EventHandler(this.btnAustralia_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(12, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(373, 342);
            this.ListBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(392, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 378);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.btnAustralia);
            this.Controls.Add(this.btnNorthAmerica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNorthAmerica;
        private System.Windows.Forms.Button btnAustralia;
        private System.Windows.Forms.ListBox ListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
    }
}

