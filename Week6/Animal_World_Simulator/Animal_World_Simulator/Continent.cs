using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_World_Simulator
{
    public abstract class Continent
    {
        public const int ANIMAL_SIM_COUNT = 3;

        protected ListBox displayBox;
        protected Random rGen;
        protected int nAnimalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        public Continent(ListBox displayBox, Random rGen, int nAnimalTypes, Graphics canvas)
        {
            this.displayBox = displayBox;
            this.rGen = rGen;
            this.nAnimalTypes = nAnimalTypes;
            this.canvas = canvas;
        }

        public void runSimulation()
        {
            displayBox.Items.Clear();
            Animal currentAnimal;

            for(int i = 0; i < ANIMAL_SIM_COUNT; i++)
            {
                int animalChoice = rGen.Next(nAnimalTypes);

                currentAnimal = animalFactory.createAnimal(animalChoice);

                displayBox.Items.Add(currentAnimal.ToString());
                canvas.DrawImage(currentAnimal.Image, 0, 0 + (i * 120), 120, 120);
            }
        }
    }
}
