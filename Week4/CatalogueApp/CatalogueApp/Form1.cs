using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogueApp
{
    public partial class Form1 : Form
    {
        private Manager manager;
        String checkedButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new Manager("../../../animalList.txt", richTextBox1, picBox1, picBox2, picBox3, picBox4);
            checkedButton = rbtnCats.Text;
        }

        private void btnShowPets_Click(object sender, EventArgs e)
        {
            manager.Show(checkedButton);            
        }

        private void rbtnCats_CheckedChanged(object sender, EventArgs e)
        {
            checkedButton = rbtnCats.Text;
        }

        private void rbtnDogs_CheckedChanged(object sender, EventArgs e)
        {
            checkedButton = rbtnDogs.Text;
        }

        private void rbtnDucks_CheckedChanged(object sender, EventArgs e)
        {
            checkedButton = rbtnDucks.Text;
        }

        private void rbtnRabbits_CheckedChanged(object sender, EventArgs e)
        {
            checkedButton = rbtnRabbits.Text;
        }
    }
}
