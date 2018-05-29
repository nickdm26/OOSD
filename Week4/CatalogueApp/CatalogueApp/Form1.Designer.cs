namespace CatalogueApp
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
            this.rbtnCats = new System.Windows.Forms.RadioButton();
            this.rbtnDogs = new System.Windows.Forms.RadioButton();
            this.rbtnDucks = new System.Windows.Forms.RadioButton();
            this.rbtnRabbits = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnShowPets = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnCats
            // 
            this.rbtnCats.AutoSize = true;
            this.rbtnCats.Checked = true;
            this.rbtnCats.Location = new System.Drawing.Point(13, 44);
            this.rbtnCats.Name = "rbtnCats";
            this.rbtnCats.Size = new System.Drawing.Size(41, 17);
            this.rbtnCats.TabIndex = 0;
            this.rbtnCats.TabStop = true;
            this.rbtnCats.Text = "Cat";
            this.rbtnCats.UseVisualStyleBackColor = true;
            this.rbtnCats.CheckedChanged += new System.EventHandler(this.rbtnCats_CheckedChanged);
            // 
            // rbtnDogs
            // 
            this.rbtnDogs.AutoSize = true;
            this.rbtnDogs.Location = new System.Drawing.Point(13, 68);
            this.rbtnDogs.Name = "rbtnDogs";
            this.rbtnDogs.Size = new System.Drawing.Size(45, 17);
            this.rbtnDogs.TabIndex = 1;
            this.rbtnDogs.Text = "Dog";
            this.rbtnDogs.UseVisualStyleBackColor = true;
            this.rbtnDogs.CheckedChanged += new System.EventHandler(this.rbtnDogs_CheckedChanged);
            // 
            // rbtnDucks
            // 
            this.rbtnDucks.AutoSize = true;
            this.rbtnDucks.Location = new System.Drawing.Point(13, 92);
            this.rbtnDucks.Name = "rbtnDucks";
            this.rbtnDucks.Size = new System.Drawing.Size(51, 17);
            this.rbtnDucks.TabIndex = 2;
            this.rbtnDucks.Text = "Duck";
            this.rbtnDucks.UseVisualStyleBackColor = true;
            this.rbtnDucks.CheckedChanged += new System.EventHandler(this.rbtnDucks_CheckedChanged);
            // 
            // rbtnRabbits
            // 
            this.rbtnRabbits.AutoSize = true;
            this.rbtnRabbits.Location = new System.Drawing.Point(13, 116);
            this.rbtnRabbits.Name = "rbtnRabbits";
            this.rbtnRabbits.Size = new System.Drawing.Size(56, 17);
            this.rbtnRabbits.TabIndex = 3;
            this.rbtnRabbits.Text = "Rabbit";
            this.rbtnRabbits.UseVisualStyleBackColor = true;
            this.rbtnRabbits.CheckedChanged += new System.EventHandler(this.rbtnRabbits_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.richTextBox1.Location = new System.Drawing.Point(13, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(175, 282);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnShowPets
            // 
            this.btnShowPets.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnShowPets.Location = new System.Drawing.Point(13, 429);
            this.btnShowPets.Name = "btnShowPets";
            this.btnShowPets.Size = new System.Drawing.Size(175, 46);
            this.btnShowPets.TabIndex = 5;
            this.btnShowPets.Text = "Show Pets!";
            this.btnShowPets.UseVisualStyleBackColor = true;
            this.btnShowPets.Click += new System.EventHandler(this.btnShowPets_Click);
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(215, 12);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(300, 300);
            this.picBox1.TabIndex = 6;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(521, 12);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(300, 300);
            this.picBox2.TabIndex = 7;
            this.picBox2.TabStop = false;
            // 
            // picBox3
            // 
            this.picBox3.Location = new System.Drawing.Point(215, 318);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(300, 300);
            this.picBox3.TabIndex = 8;
            this.picBox3.TabStop = false;
            // 
            // picBox4
            // 
            this.picBox4.Location = new System.Drawing.Point(521, 318);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(300, 300);
            this.picBox4.TabIndex = 9;
            this.picBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 625);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.btnShowPets);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rbtnRabbits);
            this.Controls.Add(this.rbtnDucks);
            this.Controls.Add(this.rbtnDogs);
            this.Controls.Add(this.rbtnCats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnCats;
        private System.Windows.Forms.RadioButton rbtnDogs;
        private System.Windows.Forms.RadioButton rbtnDucks;
        private System.Windows.Forms.RadioButton rbtnRabbits;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnShowPets;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.PictureBox picBox4;
    }
}

