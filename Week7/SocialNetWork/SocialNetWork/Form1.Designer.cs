namespace SocialNetWork
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.tabFriend1 = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBoxFriend1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.tabFriend2 = new System.Windows.Forms.TabPage();
            this.tabFriend3 = new System.Windows.Forms.TabPage();
            this.tabFriend4 = new System.Windows.Forms.TabPage();
            this.richTextBoxFriend2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFriend3 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFriend4 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            this.tabFriend1.SuspendLayout();
            this.tabFriend2.SuspendLayout();
            this.tabFriend3.SuspendLayout();
            this.tabFriend4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMainPage);
            this.tabControl1.Controls.Add(this.tabFriend1);
            this.tabControl1.Controls.Add(this.tabFriend2);
            this.tabControl1.Controls.Add(this.tabFriend3);
            this.tabControl1.Controls.Add(this.tabFriend4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMainPage
            // 
            this.tabMainPage.Controls.Add(this.btnUpdate);
            this.tabMainPage.Controls.Add(this.textBox1);
            this.tabMainPage.Controls.Add(this.richTextBoxMain);
            this.tabMainPage.Location = new System.Drawing.Point(4, 22);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainPage.Size = new System.Drawing.Size(631, 468);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.Text = "Main Page";
            this.tabMainPage.UseVisualStyleBackColor = true;
            // 
            // tabFriend1
            // 
            this.tabFriend1.Controls.Add(this.richTextBoxFriend1);
            this.tabFriend1.Location = new System.Drawing.Point(4, 22);
            this.tabFriend1.Name = "tabFriend1";
            this.tabFriend1.Padding = new System.Windows.Forms.Padding(3);
            this.tabFriend1.Size = new System.Drawing.Size(631, 468);
            this.tabFriend1.TabIndex = 1;
            this.tabFriend1.Text = "Friend1";
            this.tabFriend1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 439);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Status";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 441);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(538, 20);
            this.textBox1.TabIndex = 2;
            // 
            // richTextBoxFriend1
            // 
            this.richTextBoxFriend1.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxFriend1.Name = "richTextBoxFriend1";
            this.richTextBoxFriend1.ReadOnly = true;
            this.richTextBoxFriend1.Size = new System.Drawing.Size(619, 456);
            this.richTextBoxFriend1.TabIndex = 0;
            this.richTextBoxFriend1.Text = "";
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.ReadOnly = true;
            this.richTextBoxMain.Size = new System.Drawing.Size(619, 427);
            this.richTextBoxMain.TabIndex = 0;
            this.richTextBoxMain.Text = "";
            // 
            // tabFriend2
            // 
            this.tabFriend2.Controls.Add(this.richTextBoxFriend2);
            this.tabFriend2.Location = new System.Drawing.Point(4, 22);
            this.tabFriend2.Name = "tabFriend2";
            this.tabFriend2.Size = new System.Drawing.Size(631, 468);
            this.tabFriend2.TabIndex = 2;
            this.tabFriend2.Text = "Friend2";
            this.tabFriend2.UseVisualStyleBackColor = true;
            // 
            // tabFriend3
            // 
            this.tabFriend3.Controls.Add(this.richTextBoxFriend3);
            this.tabFriend3.Location = new System.Drawing.Point(4, 22);
            this.tabFriend3.Name = "tabFriend3";
            this.tabFriend3.Size = new System.Drawing.Size(631, 468);
            this.tabFriend3.TabIndex = 3;
            this.tabFriend3.Text = "Friend3";
            this.tabFriend3.UseVisualStyleBackColor = true;
            // 
            // tabFriend4
            // 
            this.tabFriend4.Controls.Add(this.richTextBoxFriend4);
            this.tabFriend4.Location = new System.Drawing.Point(4, 22);
            this.tabFriend4.Name = "tabFriend4";
            this.tabFriend4.Size = new System.Drawing.Size(631, 468);
            this.tabFriend4.TabIndex = 4;
            this.tabFriend4.Text = "Friend4";
            this.tabFriend4.UseVisualStyleBackColor = true;
            // 
            // richTextBoxFriend2
            // 
            this.richTextBoxFriend2.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxFriend2.Name = "richTextBoxFriend2";
            this.richTextBoxFriend2.ReadOnly = true;
            this.richTextBoxFriend2.Size = new System.Drawing.Size(625, 462);
            this.richTextBoxFriend2.TabIndex = 0;
            this.richTextBoxFriend2.Text = "";
            // 
            // richTextBoxFriend3
            // 
            this.richTextBoxFriend3.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxFriend3.Name = "richTextBoxFriend3";
            this.richTextBoxFriend3.ReadOnly = true;
            this.richTextBoxFriend3.Size = new System.Drawing.Size(625, 462);
            this.richTextBoxFriend3.TabIndex = 0;
            this.richTextBoxFriend3.Text = "";
            // 
            // richTextBoxFriend4
            // 
            this.richTextBoxFriend4.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxFriend4.Name = "richTextBoxFriend4";
            this.richTextBoxFriend4.ReadOnly = true;
            this.richTextBoxFriend4.Size = new System.Drawing.Size(625, 463);
            this.richTextBoxFriend4.TabIndex = 0;
            this.richTextBoxFriend4.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tabMainPage.PerformLayout();
            this.tabFriend1.ResumeLayout(false);
            this.tabFriend2.ResumeLayout(false);
            this.tabFriend3.ResumeLayout(false);
            this.tabFriend4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.TabPage tabFriend1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBoxFriend1;
        private System.Windows.Forms.RichTextBox richTextBoxMain;
        private System.Windows.Forms.TabPage tabFriend2;
        private System.Windows.Forms.TabPage tabFriend3;
        private System.Windows.Forms.TabPage tabFriend4;
        private System.Windows.Forms.RichTextBox richTextBoxFriend2;
        private System.Windows.Forms.RichTextBox richTextBoxFriend3;
        private System.Windows.Forms.RichTextBox richTextBoxFriend4;
    }
}

