using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogueApp
{
    class Manager
    {
        private List<Animal> animals;
        private List<Animal> speciesList;
        private String FileName;
        private RichTextBox textBox;
        private PictureBox pic1;
        private PictureBox pic2;
        private PictureBox pic3;
        private PictureBox pic4;
        private PictureBox[] picBoxes;

        private IDisplay DisplayType;

        public Manager(String FileName, RichTextBox textBox, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4)
        {
            this.FileName = FileName;
            this.textBox = textBox;
            picBoxes = new PictureBox[4];
            picBoxes[0] = pic1;
            picBoxes[1] = pic2;
            picBoxes[2] = pic3;
            picBoxes[3] = pic4;
            animals = new List<Animal>();
            LoadFromFile();
        }

        public void LoadFromFile()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(FileName);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Cant find the input file");
            }

            if(sr != null)
            {
                String currentLine = "";
                String[] currentAnimal;

                while((currentLine = sr.ReadLine()) != null)
                {
                    currentAnimal = currentLine.Split(',');

                    ESpecies currentSpecies = (ESpecies)System.Enum.Parse(typeof(ESpecies), currentAnimal[1]);
                    animals.Add(new Animal(currentAnimal[0], currentSpecies));
                }
            }
        }

        public void MakeSpeciesList(String speciesName)
        {
            speciesList = new List<Animal>();
            ESpecies currentSpecies = (ESpecies)System.Enum.Parse(typeof(ESpecies), speciesName);
            foreach (Animal a in animals)
            {
                if(a.Species == currentSpecies)
                {
                    speciesList.Add(a);
                }
            }
        }

        public void ChooseDisplay()
        {
            if(speciesList.Count > 4)
            {
                DisplayType = new TextDisplay(speciesList, textBox, picBoxes);
            }else
            {
                DisplayType = new PictureDisplay(speciesList, textBox, picBoxes);
            }
        }

        public void Show(String speciesName)
        {
            MakeSpeciesList(speciesName);
            ChooseDisplay();
            DisplayType.ClearDisplay();
            DisplayType.Display();
        }
    }
}
