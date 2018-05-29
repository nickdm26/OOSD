using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mix_N_Match
{
    public partial class Form1 : Form
    {
        Manager manager;
        Graphics canvas;
        public Form1()
        {
            InitializeComponent();
            comboBoxHead.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBody.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLegs.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHead.SelectedIndex = 0;
            comboBoxBody.SelectedIndex = 0;
            comboBoxLegs.SelectedIndex = 0;
            canvas = panel1.CreateGraphics();
            manager = new Manager(comboBoxHead, comboBoxBody, comboBoxLegs, canvas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager.MakeMonster();
        }
    }
}
