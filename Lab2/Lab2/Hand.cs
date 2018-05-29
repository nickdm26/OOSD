using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Hand
    {
        private List<int> HandCards;
        private int HCP;

        //The Hand constructer
        public Hand()
        {
            HandCards = new List<int>();
            HCP = 0;
        }
        
        //The Deck is passed in and then 13 random cards are taken out to fill up the hand list.
        public void FillHand(Deck cards)
        {
            for(int i = 0; i < 13; i++)
            {
                HandCards.Add(cards.getCard());
            }
        }

        //Calculates the HCP and the saves it in a int.
        public void CalculateHCP()
        {
            for(int i = 0; i < HandCards.Count; i++)
            {
                int remander = HandCards[i] % 13;
                if(remander > 9)
                {
                    HCP += remander - 9;
                } else if(remander == 0){
                    HCP += 4;
                }
            }
        }

        //Returns the HCP
        public int getHCP()
        {
            return HCP;
        }

        //Uses a bubblesort to sort the cards from lowest to highest in the HandCards List.
        public void sort()
        {
            for(int i = 0; i < HandCards.Count - 1; i++)
            {
                for(int j = 0; j < HandCards.Count -1; j++)
                {
                    if(HandCards[j] > HandCards[j + 1])
                    {
                        int temp = HandCards[j + 1];

                        HandCards[j + 1] = HandCards[j];
                        HandCards[j] = temp;
                    }                    
                }
            }
        }

        //The ToString method returns a formatted string to the form displaing the cards for each suit.
        public override String ToString()
        {
            String outputText = "";
            String diamond = "";
            String hearts = "";
            String clubs = "";
            String spades = "";
            for (int i = 0; i < HandCards.Count; i++)
            {
                int num = HandCards[i];
                int num2 = num % 13;

                if(num2 == 0)
                {
                    num2 = 13;
                }

                num2 += 1;
                

                if(num <= 13)
                {
                    diamond = addTo(diamond, num + 1);
                }else if( num <= 26)
                {
                    hearts = addTo(hearts, num2);
                }else if(num <= 39)
                {
                    clubs = addTo(clubs, num2);
                }else
                {
                    spades = addTo(spades, num2);
                }
            }
            outputText += "\n" + "D:   " + diamond + "\n" + "H:   " + hearts + "\n" + "C:   " + clubs + "\n" + "S:   " + spades + "\n" + "HCP:   " + getHCP().ToString();

            return outputText + " \n";
        }

        //Takes in a string and a number and changes the number to a letter if it represents a certain card. Then returns the string.
        public String addTo(String input, int num)
        {
            String outPut = input;

            if(num == 11)
            {
                outPut += "J" + " ";
            }else if(num == 12)
            {
                outPut += "Q" + " ";
            }else if(num == 13)
            {
                outPut += "K" + " ";
            }else if(num == 14)
            {
                outPut += "A";
            }else
            {
                outPut += num + " ";
            }

            return outPut;
        }


    }
}
