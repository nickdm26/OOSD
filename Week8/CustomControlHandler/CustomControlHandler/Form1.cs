using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandler
{
    public partial class Form1 : Form
    {
        CustomControlSubject subjectWithEvent;
        CustomControlObserver inst_1;
        CustomControlObserver inst_2;
        Random ran;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Form's handler");
            subjectWithEvent.onClickEvent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ran = new Random();
            subjectWithEvent = new CustomControlSubject();            
            inst_1 = new CustomControlObserver(subjectWithEvent, btn1, ran);
            inst_2 = new CustomControlObserver(subjectWithEvent, btn1, ran);
        }
    }
}
