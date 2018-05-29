using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicBridgeDealer2017
{
    public class Hand : IComparable<Hand>
    {
        public List<Card> CardsInHand { get; set; }

        public int TotalHCP
        {
            get; set;
        }

        public Hand()
        {
            CardsInHand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);
        }

        public void SortCards()
        {
            CardsInHand.Sort();
        }

        public int ComputeHCP()
        {
            TotalHCP = 0;
            foreach (Card c in CardsInHand)
                TotalHCP += c.HCP;

            return 0;
        }

        public int CompareTo(Hand otherHand)
        {
            if (this.TotalHCP == otherHand.TotalHCP)
            {
                return 0;
            }else if (this.TotalHCP > otherHand.TotalHCP)
            {
                return -1;
            }else
            {
                return 1;
            }
        }
    }
}