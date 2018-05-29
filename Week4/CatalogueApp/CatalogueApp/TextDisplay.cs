using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogueApp
{
    class TextDisplay : IDisplay
    {
        private List<Animal> speciesList;
        private RichTextBox textBox;
        private PictureBox[] picBoxes;

        public TextDisplay(List<Animal> speciesList, RichTextBox textBox, PictureBox[] picBoxes)
        {
            this.speciesList = speciesList;
            this.textBox = textBox;
            this.picBoxes = picBoxes;
        }

        public void Display()
        {
            String output = "";
            for (int i = 0; i < speciesList.Count; i++)
            {
                output += speciesList[i].ToString() + "\n";
            }
            textBox.Text = output;
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