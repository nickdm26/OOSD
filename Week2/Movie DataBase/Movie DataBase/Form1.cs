/*
 * Nick Muldrew
 * The Form Class calls the methods and passes the input through to the Manager class.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_DataBase
{
    public partial class Form1 : Form
    {

        Manager manager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new Manager();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            manager.Add(txtbAddYear, txtbAddTitle, txtbAddDirector);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            manager.Search(listBox1, txtbSearchYear.Text);
            txtbSearchYear.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            manager.Delete(listBox1, txtbDeleteYear.Text);
            txtbDeleteYear.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            manager.PrintAll(listBox1);
        }
    }
}