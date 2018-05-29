using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Deck
    {
        private List<int> Cards;
        private Random rGen = new Random();
        
        //Fills the Cards list with numbers from 1 to 52
        public Deck()
        {
            Cards = new List<int>();
            for(int i = 1; i < 53; i++)
            {
                Cards.Add(i);
            }
        }

        //Returns a random card from the Cards List and removes it.
        public int getCard()
        {
            int postion = rGen.Next(Cards.Count);
            int value = Cards[postion];
            Cards.RemoveAt(postion);
            return value;
        }
    }
}
