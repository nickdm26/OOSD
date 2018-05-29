﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_World_Simulator
{
    public class Wolf : Animal
    {
        public Wolf()
        {
            name = "Wolf";
            family = "Carnivore";
            food = "Deer";
            image = new Bitmap("../../Images/wolf.jpg");
        }
    }
}
