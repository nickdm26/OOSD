namespace WeatherMonitor
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTempInput = new System.Windows.Forms.Label();
            this.txtBTemp = new System.Windows.Forms.TextBox();
            this.txtBHumidity = new System.Windows.Forms.TextBox();
            this.txtBPressure = new System.Windows.Forms.TextBox();
            this.lblHumidityInput = new System.Windows.Forms.Label();
            this.lblBarometric = new System.Windows.Forms.Label();
            this.lblTempOutput = new System.Windows.Forms.Label();
            this.lblAvergeReadings = new System.Windows.Forms.Label();
            this.lblForcast = new System.Windows.Forms.Label();
            this.richTextBoxForcast = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAverage = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTemp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 48);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Measurements";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTempInput
            // 
            this.lblTempInput.AutoSize = true;
            this.lblTempInput.Location = new System.Drawing.Point(13, 68);
            this.lblTempInput.Name = "lblTempInput";
            this.lblTempInput.Size = new System.Drawing.Size(83, 13);
            this.lblTempInput.TabIndex = 1;
            this.lblTempInput.Text = "Temperature (C)";
            // 
            // txtBTemp
            // 
            this.txtBTemp.Location = new System.Drawing.Point(13, 85);
            this.txtBTemp.Name = "txtBTemp";
            this.txtBTemp.Size = new System.Drawing.Size(100, 20);
            this.txtBTemp.TabIndex = 2;
            // 
            // txtBHumidity
            // 
            this.txtBHumidity.Location = new System.Drawing.Point(13, 148);
            this.txtBHumidity.Name = "txtBHumidity";
            this.txtBHumidity.Size = new System.Drawing.Size(100, 20);
            this.txtBHumidity.TabIndex = 4;
            // 
            // txtBPressure
            // 
            this.txtBPressure.Location = new System.Drawing.Point(13, 206);
            this.txtBPressure.Name = "txtBPressure";
            this.txtBPressure.Size = new System.Drawing.Size(100, 20);
            this.txtBPressure.TabIndex = 5;
            // 
            // lblHumidityInput
            // 
            this.lblHumidityInput.AutoSize = true;
            this.lblHumidityInput.Location = new System.Drawing.Point(13, 129);
            this.lblHumidityInput.Name = "lblHumidityInput";
            this.lblHumidityInput.Size = new System.Drawing.Size(64, 13);
            this.lblHumidityInput.TabIndex = 6;
            this.lblHumidityInput.Text = "Humidity (%)";
            // 
            // lblBarometric
            // 
            this.lblBarometric.AutoSize = true;
            this.lblBarometric.Location = new System.Drawing.Point(13, 187);
            this.lblBarometric.Name = "lblBarometric";
            this.lblBarometric.Size = new System.Drawing.Size(101, 13);
            this.lblBarometric.TabIndex = 7;
            this.lblBarometric.Text = "Barometric Pressure";
            // 
            // lblTempOutput
            // 
            this.lblTempOutput.AutoSize = true;
            this.lblTempOutput.Location = new System.Drawing.Point(190, 13);
            this.lblTempOutput.Name = "lblTempOutput";
            this.lblTempOutput.Size = new System.Drawing.Size(83, 13);
            this.lblTempOutput.TabIndex = 8;
            this.lblTempOutput.Text = "Temperature (C)";
            // 
            // lblAvergeReadings
            // 
            this.lblAvergeReadings.AutoSize = true;
            this.lblAvergeReadings.Location = new System.Drawing.Point(190, 148);
            this.lblAvergeReadings.Name = "lblAvergeReadings";
            this.lblAvergeReadings.Size = new System.Drawing.Size(95, 13);
            this.lblAvergeReadings.TabIndex = 9;
            this.lblAvergeReadings.Text = "Average Readings";
            // 
            // lblForcast
            // 
            this.lblForcast.AutoSize = true;
            this.lblForcast.Location = new System.Drawing.Point(190, 276);
            this.lblForcast.Name = "lblForcast";
            this.lblForcast.Size = new System.Drawing.Size(42, 13);
            this.lblForcast.TabIndex = 10;
            this.lblForcast.Text = "Forcast";
            // 
            // richTextBoxForcast
            // 
            this.richTextBoxForcast.Location = new System.Drawing.Point(193, 294);
            this.richTextBoxForcast.Name = "richTextBoxForcast";
            this.richTextBoxForcast.ReadOnly = true;
            this.richTextBoxForcast.Size = new System.Drawing.Size(321, 96);
            this.richTextBoxForcast.TabIndex = 17;
            this.richTextBoxForcast.Text = "";
            // 
            // richTextBoxAverage
            // 
            this.richTextBoxAverage.Location = new System.Drawing.Point(193, 165);
            this.richTextBoxAverage.Name = "richTextBoxAverage";
            this.richTextBoxAverage.ReadOnly = true;
            this.richTextBoxAverage.Size = new System.Drawing.Size(321, 96);
            this.richTextBoxAverage.TabIndex = 18;
            this.richTextBoxAverage.Text = "";
            // 
            // richTextBoxTemp
            // 
            this.richTextBoxTemp.Location = new System.Drawing.Point(193, 30);
            this.richTextBoxTemp.Name = "richTextBoxTemp";
            this.richTextBoxTemp.ReadOnly = true;
            this.richTextBoxTemp.Size = new System.Drawing.Size(321, 96);
            this.richTextBoxTemp.TabIndex = 19;
            this.richTextBoxTemp.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 402);
            this.Controls.Add(this.richTextBoxTemp);
            this.Controls.Add(this.richTextBoxAverage);
            this.Controls.Add(this.richTextBoxForcast);
            this.Controls.Add(this.lblForcast);
            this.Controls.Add(this.lblAvergeReadings);
            this.Controls.Add(this.lblTempOutput);
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

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTempInput;
        private System.Windows.Forms.TextBox txtBTemp;
        private System.Windows.Forms.TextBox txtBHumidity;
        private System.Windows.Forms.TextBox txtBPressure;
        private System.Windows.Forms.Label lblHumidityInput;
        private System.Windows.Forms.Label lblBarometric;
        private System.Windows.Forms.Label lblTempOutput;
        private System.Windows.Forms.Label lblAvergeReadings;
        private System.Windows.Forms.Label lblForcast;
        private System.Windows.Forms.RichTextBox richTextBoxForcast;
        private System.Windows.Forms.RichTextBox richTextBoxAverage;
        private System.Windows.Forms.RichTextBox richTextBoxTemp;
    }
}

