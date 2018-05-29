using DogSelector.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogSelector.Models
{
    public class Dog
    {
        public string BreedName { get; set; }
        public string DisplayName { get; set; }
        public string ImageName { get; set; }
        public Enums.EScale ActivityLevel { get; set; }
        public Enums.EScale SheddingLevel { get; set; }
        public Enums.EScale GroomingLevel { get; set; }
        public Enums.EScale IntelligenceLevel { get; set; }
        public bool GoodWithChildren { get; set; }
        public bool Drools { get; set; }
        public Enums.ELength Coatlength { get; set; }
        public Enums.ESize Size { get; set; }

        public bool CompareTo(Dog otherDog)
        {
            if(otherDog.ActivityLevel == Enums.EScale.None)
            {

            }
            else if (!ActivityLevel.Equals(otherDog.ActivityLevel))
            {
                return false;
            }

            if(otherDog.SheddingLevel == Enums.EScale.None)
            {

            }
            else if (!SheddingLevel.Equals(otherDog.SheddingLevel))
            {
                return false;
            }

            if(otherDog.GroomingLevel == Enums.EScale.None)
            {

            }
            else if (!GroomingLevel.Equals(otherDog.GroomingLevel))
            {
                return false;
            }

            if(otherDog.IntelligenceLevel == Enums.EScale.None)
            {

            }
            else if (!IntelligenceLevel.Equals(otherDog.IntelligenceLevel))
            {
                return false;
            }

            if (!GoodWithChildren.Equals(otherDog.GoodWithChildren))
            {
                return false;
            }

            if (!Coatlength.Equals(otherDog.Coatlength))
            {
                return false;
            }

            if (!Size.Equals(otherDog.Size))
            {
                return false;
            }
            return true;
        }
    }
}