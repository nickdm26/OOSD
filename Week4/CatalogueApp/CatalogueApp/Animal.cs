using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueApp
{
    public enum ESpecies { Cat, Dog, Rabbit, Duck };
    class Animal
    {
        private string name;
        private string imageFileName;

        public string Name
        {
            get { return name; }
            set { name = value;  imageFileName = "../../../images/" + name + ".jpg"; }
        }

        public string ImageFileName
        {
            get { return imageFileName; }
        }

        public ESpecies Species
        {
            get;
            set;
        }

        public Animal(string name, ESpecies species)
        {
            this.name = name;
            Species = species;
            imageFileName = "../../../images/" + name + ".jpg";
        }

        public override string ToString()
        {
            return name + ": " + Species.ToString();
        }
    }
}
