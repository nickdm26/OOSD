﻿namespace PredicateDemo
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
            this.btnRanNumbers = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnEvenNums = new System.Windows.Forms.Button();
            this.btnLessThen10 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRanNumbers
            // 
            this.btnRanNumbers.Location = new System.Drawing.Point(35, 44);
            this.btnRanNumbers.Name = "btnRanNumbers";
            this.btnRanNumbers.Size = new System.Drawing.Size(116, 48);
            this.btnRanNumbers.TabIndex = 0;
            this.btnRanNumbers.Text = "Generate Random Numbers";
            this.btnRanNumbers.UseVisualStyleBackColor = true;
            this.btnRanNumbers.Click += new System.EventHandler(this.btnRanNumbers_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(116, 536);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnEvenNums
            // 
            this.btnEvenNums.Location = new System.Drawing.Point(231, 51);
            this.btnEvenNums.Name = "btnEvenNums";
            this.btnEvenNums.Size = new System.Drawing.Size(84, 42);
            this.btnEvenNums.TabIndex = 2;
            this.btnEvenNums.Text = "Select Even Numbers";
            this.btnEvenNums.UseVisualStyleBackColor = true;
            this.btnEvenNums.Click += new System.EventHandler(this.btnEvenNums_Click);
            // 
            // btnLessThen10
            // 
            this.btnLessThen10.Location = new System.Drawing.Point(321, 50);
            this.btnLessThen10.Name = "btnLessThen10";
            this.btnLessThen10.Size = new System.Drawing.Size(81, 42);
            this.btnLessThen10.TabIndex = 3;
            this.btnLessThen10.Text = "Select x < 10";
            this.btnLessThen10.UseVisualStyleBackColor = true;
            this.btnLessThen10.Click += new System.EventHandler(this.btnLessThen10_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(231, 99);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(171, 536);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 647);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnLessThen10);
            this.Controls.Add(this.btnEvenNums);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnRanNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRanNumbers;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnEvenNums;
        private System.Windows.Forms.Button btnLessThen10;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

