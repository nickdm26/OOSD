using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionMachine
{
    public partial class Form1 : Form
    {
        EncryptionDecryptionInterface EncryptDecrypt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtbOuput.Text = EncryptDecrypt.Encrypt(txtbInput.Text);
        }

        private void btnDecyrpt_Click(object sender, EventArgs e)
        {
            txtbOuput.Text = EncryptDecrypt.Decrypt(txtbInput.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EncryptDecrypt = new Reversal();
        }

        private void rbtnReverse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnReverse.Checked)
            {
                EncryptDecrypt = new Reversal();
            }
        }

        private void rtbnROT13_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbnROT13.Checked)
            {
                EncryptDecrypt = new ROT13();
            }
        }
    }
}
