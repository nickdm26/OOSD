namespace Movie_DataBase
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAddYear = new System.Windows.Forms.Label();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAddDirector = new System.Windows.Forms.Label();
            this.txtbAddYear = new System.Windows.Forms.TextBox();
            this.txtbAddTitle = new System.Windows.Forms.TextBox();
            this.txtbAddDirector = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtbDeleteYear = new System.Windows.Forms.TextBox();
            this.lblDeleteYear = new System.Windows.Forms.Label();
            this.txtbSearchYear = new System.Windows.Forms.TextBox();
            this.lblSearchYear = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAddYear
            // 
            this.lblAddYear.AutoSize = true;
            this.lblAddYear.Location = new System.Drawing.Point(117, 23);
            this.lblAddYear.Name = "lblAddYear";
            this.lblAddYear.Size = new System.Drawing.Size(29, 13);
            this.lblAddYear.TabIndex = 1;
            this.lblAddYear.Text = "Year";
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(117, 48);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(27, 13);
            this.lblAddTitle.TabIndex = 2;
            this.lblAddTitle.Text = "Title";
            // 
            // lblAddDirector
            // 
            this.lblAddDirector.AutoSize = true;
            this.lblAddDirector.Location = new System.Drawing.Point(117, 76);
            this.lblAddDirector.Name = "lblAddDirector";
            this.lblAddDirector.Size = new System.Drawing.Size(44, 13);
            this.lblAddDirector.TabIndex = 3;
            this.lblAddDirector.Text = "Director";
            // 
            // txtbAddYear
            // 
            this.txtbAddYear.Location = new System.Drawing.Point(172, 15);
            this.txtbAddYear.Name = "txtbAddYear";
            this.txtbAddYear.Size = new System.Drawing.Size(431, 20);
            this.txtbAddYear.TabIndex = 4;
            // 
            // txtbAddTitle
            // 
            this.txtbAddTitle.Location = new System.Drawing.Point(172, 44);
            this.txtbAddTitle.Name = "txtbAddTitle";
            this.txtbAddTitle.Size = new System.Drawing.Size(431, 20);
            this.txtbAddTitle.TabIndex = 5;
            // 
            // txtbAddDirector
            // 
            this.txtbAddDirector.Location = new System.Drawing.Point(171, 72);
            this.txtbAddDirector.Name = "txtbAddDirector";
            this.txtbAddDirector.Size = new System.Drawing.Size(431, 20);
            this.txtbAddDirector.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtbDeleteYear
            // 
            this.txtbDeleteYear.Location = new System.Drawing.Point(171, 143);
            this.txtbDeleteYear.Name = "txtbDeleteYear";
            this.txtbDeleteYear.Size = new System.Drawing.Size(431, 20);
            this.txtbDeleteYear.TabIndex = 9;
            // 
            // lblDeleteYear
            // 
            this.lblDeleteYear.AutoSize = true;
            this.lblDeleteYear.Location = new System.Drawing.Point(116, 151);
            this.lblDeleteYear.Name = "lblDeleteYear";
            this.lblDeleteYear.Size = new System.Drawing.Size(29, 13);
            this.lblDeleteYear.TabIndex = 8;
            this.lblDeleteYear.Text = "Year";
            // 
            // txtbSearchYear
            // 
            this.txtbSearchYear.Location = new System.Drawing.Point(171, 205);
            this.txtbSearchYear.Name = "txtbSearchYear";
            this.txtbSearchYear.Size = new System.Drawing.Size(431, 20);
            this.txtbSearchYear.TabIndex = 12;
            // 
            // lblSearchYear
            // 
            this.lblSearchYear.AutoSize = true;
            this.lblSearchYear.Location = new System.Drawing.Point(116, 213);
            this.lblSearchYear.Name = "lblSearchYear";
            this.lblSearchYear.Size = new System.Drawing.Size(29, 13);
            this.lblSearchYear.TabIndex = 11;
            this.lblSearchYear.Text = "Year";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(13, 202);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(13, 263);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print All";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(171, 263);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 199);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 476);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtbSearchYear);
            this.Controls.Add(this.lblSearchYear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbDeleteYear);
            this.Controls.Add(this.lblDeleteYear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtbAddDirector);
            this.Controls.Add(this.txtbAddTitle);
            this.Controls.Add(this.txtbAddYear);
            this.Controls.Add(this.lblAddDirector);
            this.Controls.Add(this.lblAddTitle);
            this.Controls.Add(this.lblAddYear);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAddYear;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblAddDirector;
        private System.Windows.Forms.TextBox txtbAddYear;
        private System.Windows.Forms.TextBox txtbAddTitle;
        private System.Windows.Forms.TextBox txtbAddDirector;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtbDeleteYear;
        private System.Windows.Forms.Label lblDeleteYear;
        private System.Windows.Forms.TextBox txtbSearchYear;
        private System.Windows.Forms.Label lblSearchYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox listBox1;
    }
}

