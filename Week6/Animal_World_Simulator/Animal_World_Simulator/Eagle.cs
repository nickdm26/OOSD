﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    public class Eagle : Animal
    {
        public Eagle()
        {
            name = "Eagle";
            family = "Carnivore";
            food = "Fish";
            image = new Bitmap("../../Images/bald_eagle.jpg");
        }
    }
}
