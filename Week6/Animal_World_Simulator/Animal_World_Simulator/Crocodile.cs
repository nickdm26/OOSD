using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    public class Crocodile : Animal
    {
        public Crocodile()
        {
            name = "Crocodile";
            family = "Carnivore";
            food = "Babys";
            image = new Bitmap("../../Images/crocodile.jpg");
        }
    }
}
