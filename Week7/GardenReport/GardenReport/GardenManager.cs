using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReport
{
    public class GardenManager
    {
        private List<Garden> gardens;
        private RichTextBox txtBox;
        public delegate void GardenDelgate();

        public GardenManager(RichTextBox txtBox)
        {
            this.txtBox = txtBox;
            gardens = new List<Garden>();
            Garden garden1 = new Garden(150, 100, "Nick Muldrew");
            Garden garden2 = new Garden(200, 300, "John Doe");
            Garden garden3 = new Garden(150, 450, "Nick Doe");
            gardens.Add(garden1);
            gardens.Add(garden2);
            gardens.Add(garden3);
        }        

        public void ProcessGardens(GardenDelgate gardendelgate)
        {
            txtBox.Text = "";
            foreach(Garden element in gardens)
            {
                txtBox.Text += "Hello " +  "\n";
            }
        }

        public void test()
        {
            GardenDelgate delgate = new GardenDelgate(GetArea);
        }
    }
}
