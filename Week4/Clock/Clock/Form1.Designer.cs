namespace Clock
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
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.rbtnDigital = new System.Windows.Forms.RadioButton();
            this.rbtnAnalog = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDigital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(53, 125);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(237, 237);
            this.analogClock1.TabIndex = 0;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnStart.Location = new System.Drawing.Point(53, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 58);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnStop.Location = new System.Drawing.Point(175, 61);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 58);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // rbtnDigital
            // 
            this.rbtnDigital.AutoSize = true;
            this.rbtnDigital.Checked = true;
            this.rbtnDigital.Location = new System.Drawing.Point(297, 61);
            this.rbtnDigital.Name = "rbtnDigital";
            this.rbtnDigital.Size = new System.Drawing.Size(54, 17);
            this.rbtnDigital.TabIndex = 3;
            this.rbtnDigital.TabStop = true;
            this.rbtnDigital.Text = "Digital";
            this.rbtnDigital.UseVisualStyleBackColor = true;
            this.rbtnDigital.CheckedChanged += new System.EventHandler(this.rbtnDigital_CheckedChanged);
            // 
            // rbtnAnalog
            // 
            this.rbtnAnalog.AutoSize = true;
            this.rbtnAnalog.Location = new System.Drawing.Point(297, 102);
            this.rbtnAnalog.Name = "rbtnAnalog";
            this.rbtnAnalog.Size = new System.Drawing.Size(58, 17);
            this.rbtnAnalog.TabIndex = 4;
            this.rbtnAnalog.Text = "Analog";
            this.rbtnAnalog.UseVisualStyleBackColor = true;
            this.rbtnAnalog.CheckedChanged += new System.EventHandler(this.rbtnAnalog_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDigital
            // 
            this.lblDigital.AutoSize = true;
            this.lblDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblDigital.Location = new System.Drawing.Point(53, 202);
            this.lblDigital.Name = "lblDigital";
            this.lblDigital.Size = new System.Drawing.Size(237, 63);
            this.lblDigital.TabIndex = 5;
            this.lblDigital.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 395);
            this.Controls.Add(this.lblDigital);
            this.Controls.Add(this.rbtnAnalog);
            this.Controls.Add(this.rbtnDigital);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.analogClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnalogClockControl.AnalogClock analogClock1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RadioButton rbtnDigital;
        private System.Windows.Forms.RadioButton rbtnAnalog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDigital;
    }
}

