using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GardenReport.Garden;
using static GardenReport.GardenManager;

namespace GardenReport
{
    public partial class Form1 : Form
    {
        GardenManager manager;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAreaReport_Click(object sender, EventArgs e)
        {
            GardenDelgate delgate = new GardenDelgate(GetArea);
            manager.ProcessGardens(delgate);
        }

        private void btnChargesReport_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new GardenManager(richTextBox1);
        }
    }
}
