using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetWork
{
    public partial class Form1 : Form
    {
        SocialNetWorkSubject subject;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            subject.NotifyObserver(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new SocialNetWorkSubject(textBox1.Text);
            PageBase obMain = new MainPage(textBox1.Text, richTextBoxMain, subject);
            PageBase obFriend1 = new Friend1(textBox1.Text, richTextBoxFriend1, subject);
            PageBase obFriend2 = new Friend2(textBox1.Text, richTextBoxFriend2, subject);
            PageBase obFriend3 = new Friend3(textBox1.Text, richTextBoxFriend3, subject);
            PageBase obFriend4 = new Friend4(textBox1.Text, richTextBoxFriend4, subject);

        }
    }
}
