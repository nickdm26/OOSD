namespace Mix_N_Match
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxHead = new System.Windows.Forms.ComboBox();
            this.comboBoxBody = new System.Windows.Forms.ComboBox();
            this.comboBoxLegs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 870);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxHead
            // 
            this.comboBoxHead.FormattingEnabled = true;
            this.comboBoxHead.Items.AddRange(new object[] {
            "Fairy",
            "Frankenstein",
            "Skeleton",
            "Vampire",
            "Werewolf",
            "Witch"});
            this.comboBoxHead.Location = new System.Drawing.Point(556, 12);
            this.comboBoxHead.Name = "comboBoxHead";
            this.comboBoxHead.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHead.TabIndex = 1;
            // 
            // comboBoxBody
            // 
            this.comboBoxBody.FormattingEnabled = true;
            this.comboBoxBody.Items.AddRange(new object[] {
            "Fairy",
            "Frankenstein",
            "Skeleton",
            "Vampire",
            "Werewolf",
            "Witch"});
            this.comboBoxBody.Location = new System.Drawing.Point(556, 47);
            this.comboBoxBody.Name = "comboBoxBody";
            this.comboBoxBody.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBody.TabIndex = 2;
            // 
            // comboBoxLegs
            // 
            this.comboBoxLegs.FormattingEnabled = true;
            this.comboBoxLegs.Items.AddRange(new object[] {
            "Fairy",
            "Frankenstein",
            "Skeleton",
            "Vampire",
            "Werewolf",
            "Witch"});
            this.comboBoxLegs.Location = new System.Drawing.Point(556, 81);
            this.comboBoxLegs.Name = "comboBoxLegs";
            this.comboBoxLegs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLegs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Head";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Legs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Make Monster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 878);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLegs);
            this.Controls.Add(this.comboBoxBody);
            this.Controls.Add(this.comboBoxHead);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxHead;
        private System.Windows.Forms.ComboBox comboBoxBody;
        private System.Windows.Forms.ComboBox comboBoxLegs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

