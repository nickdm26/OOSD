﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    public class Ram
    {
        protected string name;
        protected int price;

        public int Price
        {
            get { return price; }
        }

        public override string ToString()
        {
            string displayString = "" + price.ToString() + "    " + name;
            return displayString;
        }
    }
}
