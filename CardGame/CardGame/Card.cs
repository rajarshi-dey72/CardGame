using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Card
    {
        private readonly CardSuits suit;
        private readonly CardValues value;
       
        public Card(int iSuit, int iValue)
        {
            // setting  private varibles for card
            suit = (CardSuits)(iSuit);
            value = (CardValues)(iValue);
        }
        // properties of cards
        public CardSuits CardSuit
        {
            get { return suit; }
        }

        public CardValues CardValue
        {
            get { return value; }
        }

        /// <summary>
        /// Card Suits enum
        /// </summary>
        public enum CardSuits
        {
            Clubs = 0,
            Hearts = 1,
            Spades = 2,
            Diamonds = 3
        }
        /// <summary>
        /// Card Values enum
        /// </summary>
        public enum CardValues
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
            
        }

    }
}
