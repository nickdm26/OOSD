namespace ComputerBuilder
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbtnGame = new System.Windows.Forms.RadioButton();
            this.rbtnBusiness = new System.Windows.Forms.RadioButton();
            this.rbtnMultimedia = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnLaptop = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print Specs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(108, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(471, 381);
            this.listBox1.TabIndex = 1;
            // 
            // rbtnGame
            // 
            this.rbtnGame.AutoSize = true;
            this.rbtnGame.Checked = true;
            this.rbtnGame.Location = new System.Drawing.Point(13, 85);
            this.rbtnGame.Name = "rbtnGame";
            this.rbtnGame.Size = new System.Drawing.Size(53, 17);
            this.rbtnGame.TabIndex = 2;
            this.rbtnGame.TabStop = true;
            this.rbtnGame.Text = "Game";
            this.rbtnGame.UseVisualStyleBackColor = true;
            // 
            // rbtnBusiness
            // 
            this.rbtnBusiness.AutoSize = true;
            this.rbtnBusiness.Location = new System.Drawing.Point(12, 108);
            this.rbtnBusiness.Name = "rbtnBusiness";
            this.rbtnBusiness.Size = new System.Drawing.Size(67, 17);
            this.rbtnBusiness.TabIndex = 3;
            this.rbtnBusiness.Text = "Business";
            this.rbtnBusiness.UseVisualStyleBackColor = true;
            // 
            // rbtnMultimedia
            // 
            this.rbtnMultimedia.AutoSize = true;
            this.rbtnMultimedia.Location = new System.Drawing.Point(12, 131);
            this.rbtnMultimedia.Name = "rbtnMultimedia";
            this.rbtnMultimedia.Size = new System.Drawing.Size(75, 17);
            this.rbtnMultimedia.TabIndex = 4;
            this.rbtnMultimedia.Text = "Multimedia";
            this.rbtnMultimedia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Machine Type";
            // 
            // rbtnLaptop
            // 
            this.rbtnLaptop.AutoSize = true;
            this.rbtnLaptop.Location = new System.Drawing.Point(12, 155);
            this.rbtnLaptop.Name = "rbtnLaptop";
            this.rbtnLaptop.Size = new System.Drawing.Size(58, 17);
            this.rbtnLaptop.TabIndex = 6;
            this.rbtnLaptop.TabStop = true;
            this.rbtnLaptop.Text = "Laptop";
            this.rbtnLaptop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 412);
            this.Controls.Add(this.rbtnLaptop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnMultimedia);
            this.Controls.Add(this.rbtnBusiness);
            this.Controls.Add(this.rbtnGame);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbtnGame;
        private System.Windows.Forms.RadioButton rbtnBusiness;
        private System.Windows.Forms.RadioButton rbtnMultimedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnLaptop;
    }
}

