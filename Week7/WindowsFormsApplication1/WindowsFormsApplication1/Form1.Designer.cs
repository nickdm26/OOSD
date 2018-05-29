namespace WindowsFormsApplication1
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
            this.listBoxForcast = new System.Windows.Forms.ListBox();
            this.listBoxAverage = new System.Windows.Forms.ListBox();
            this.listBoxTemp = new System.Windows.Forms.ListBox();
            this.lblForcast = new System.Windows.Forms.Label();
            this.lblAvergeReadings = new System.Windows.Forms.Label();
            this.lblBarometric = new System.Windows.Forms.Label();
            this.lblHumidityInput = new System.Windows.Forms.Label();
            this.txtBPressure = new System.Windows.Forms.TextBox();
            this.txtBHumidity = new System.Windows.Forms.TextBox();
            this.txtBTemp = new System.Windows.Forms.TextBox();
            this.lblTempInput = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxForcast
            // 
            this.listBoxForcast.FormattingEnabled = true;
            this.listBoxForcast.Location = new System.Drawing.Point(192, 292);
            this.listBoxForcast.Name = "listBoxForcast";
            this.listBoxForcast.Size = new System.Drawing.Size(321, 95);
            this.listBoxForcast.TabIndex = 28;
            // 
            // listBoxAverage
            // 
            this.listBoxAverage.FormattingEnabled = true;
            this.listBoxAverage.Location = new System.Drawing.Point(192, 164);
            this.listBoxAverage.Name = "listBoxAverage";
            this.listBoxAverage.Size = new System.Drawing.Size(321, 95);
            this.listBoxAverage.TabIndex = 27;
            // 
            // listBoxTemp
            // 
            this.listBoxTemp.FormattingEnabled = true;
            this.listBoxTemp.Location = new System.Drawing.Point(192, 29);
            this.listBoxTemp.Name = "listBoxTemp";
            this.listBoxTemp.Size = new System.Drawing.Size(321, 95);
            this.listBoxTemp.TabIndex = 26;
            // 
            // lblForcast
            // 
            this.lblForcast.AutoSize = true;
            this.lblForcast.Location = new System.Drawing.Point(189, 275);
            this.lblForcast.Name = "lblForcast";
            this.lblForcast.Size = new System.Drawing.Size(42, 13);
            this.lblForcast.TabIndex = 25;
            this.lblForcast.Text = "Forcast";
            // 
            // lblAvergeReadings
            // 
            this.lblAvergeReadings.AutoSize = true;
            this.lblAvergeReadings.Location = new System.Drawing.Point(189, 147);
            this.lblAvergeReadings.Name = "lblAvergeReadings";
            this.lblAvergeReadings.Size = new System.Drawing.Size(95, 13);
            this.lblAvergeReadings.TabIndex = 24;
            this.lblAvergeReadings.Text = "Average Readings";
            // 
            // lblBarometric
            // 
            this.lblBarometric.AutoSize = true;
            this.lblBarometric.Location = new System.Drawing.Point(12, 186);
            this.lblBarometric.Name = "lblBarometric";
            this.lblBarometric.Size = new System.Drawing.Size(101, 13);
            this.lblBarometric.TabIndex = 23;
            this.lblBarometric.Text = "Barometric Pressure";
            // 
            // lblHumidityInput
            // 
            this.lblHumidityInput.AutoSize = true;
            this.lblHumidityInput.Location = new System.Drawing.Point(12, 128);
            this.lblHumidityInput.Name = "lblHumidityInput";
            this.lblHumidityInput.Size = new System.Drawing.Size(64, 13);
            this.lblHumidityInput.TabIndex = 22;
            this.lblHumidityInput.Text = "Humidity (%)";
            // 
            // txtBPressure
            // 
            this.txtBPressure.Location = new System.Drawing.Point(12, 205);
            this.txtBPressure.Name = "txtBPressure";
            this.txtBPressure.Size = new System.Drawing.Size(100, 20);
            this.txtBPressure.TabIndex = 21;
            // 
            // txtBHumidity
            // 
            this.txtBHumidity.Location = new System.Drawing.Point(12, 147);
            this.txtBHumidity.Name = "txtBHumidity";
            this.txtBHumidity.Size = new System.Drawing.Size(100, 20);
            this.txtBHumidity.TabIndex = 20;
            // 
            // txtBTemp
            // 
            this.txtBTemp.Location = new System.Drawing.Point(12, 84);
            this.txtBTemp.Name = "txtBTemp";
            this.txtBTemp.Size = new System.Drawing.Size(100, 20);
            this.txtBTemp.TabIndex = 19;
            // 
            // lblTempInput
            // 
            this.lblTempInput.AutoSize = true;
            this.lblTempInput.Location = new System.Drawing.Point(12, 67);
            this.lblTempInput.Name = "lblTempInput";
            this.lblTempInput.Size = new System.Drawing.Size(83, 13);
            this.lblTempInput.TabIndex = 18;
            this.lblTempInput.Text = "Temperature (C)";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 48);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Measurements";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 401);
            this.Controls.Add(this.listBoxForcast);
            this.Controls.Add(this.listBoxAverage);
            this.Controls.Add(this.listBoxTemp);
            this.Controls.Add(this.lblForcast);
            this.Controls.Add(this.lblAvergeReadings);
            this.Controls.Add(this.lblBarometric);
            this.Controls.Add(this.lblHumidityInput);
            this.Controls.Add(this.txtBPressure);
            this.Controls.Add(this.txtBHumidity);
            this.Controls.Add(this.txtBTemp);
            this.Controls.Add(this.lblTempInput);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxForcast;
        private System.Windows.Forms.ListBox listBoxAverage;
        private System.Windows.Forms.ListBox listBoxTemp;
        private System.Windows.Forms.Label lblForcast;
        private System.Windows.Forms.Label lblAvergeReadings;
        private System.Windows.Forms.Label lblBarometric;
        private System.Windows.Forms.Label lblHumidityInput;
        private System.Windows.Forms.TextBox txtBPressure;
        private System.Windows.Forms.TextBox txtBHumidity;
        private System.Windows.Forms.TextBox txtBTemp;
        private System.Windows.Forms.Label lblTempInput;
        private System.Windows.Forms.Button btnUpdate;
    }
}

