using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogueApp
{
    class PictureDisplay : IDisplay
    {
        private List<Animal> speciesList;
        private RichTextBox textBox;
        private PictureBox[] picBoxes;

        public PictureDisplay(List<Animal> speciesList, RichTextBox textBox, PictureBox[] picBoxes)
        {
            this.speciesList = speciesList;
            this.textBox = textBox;
            this.picBoxes = picBoxes;
        }

        public void Display()
        {
            for(int i = 0;i < speciesList.Count; i++)
            {
                picBoxes[i].Load(speciesList[i].ImageFileName);
                picBoxes[i].Show();
            }
        }

        public void ClearDisplay()
        {
            textBox.Clear();
            for (int i = 0; i < picBoxes.Length; i++)
            {
                picBoxes[i].Hide();
            }
        }
    }
}
