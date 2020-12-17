using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        public List<Card> CardSet;

        //Random Number generation variable
        private static readonly Random rand = new Random();

        /// <summary>
        /// Generates random number within the range of min to max-1
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Random Number Integer</returns>
        public int RandomNumber(int min, int max)
        {
            return rand.Next(min, max);
        }
        public Deck()
        {
            CardSet = new List<Card>();
            for (int i = 0; i < 4; i++)         //Suit values 0-3 (0-Clubs, 1-Hearts, 2-Spades,3-Diamonds)
            {
                for (int j = 1; j < 14; j++)    //Card values 1-13 (values ordered from  ace to king)
                {
                    CardSet.Add(new Card(i, j));
                }
            }
            this.Shuffle();// card picked should be in a random order
        }

        /// <summary>
        /// Shuffle the deck.
        /// </summary>
        private void Shuffle()
        {
            for (int i = 0; i < CardSet.Count; i++)
            {
                
                var temp = CardSet[i];
                var index = RandomNumber(0, CardSet.Count);// swap with a random card from the deck
                CardSet[i] = CardSet[index];
                CardSet[index] = temp;
            }
        }
        /// <summary>
        /// Draw a card from the deck.
        /// </summary>
        /// <returns>return the top card from the deck</returns>
        private Card DrawCard()
        {

            // int index = RandomNumber(0, CardSet.Count);// Pick any random card from the deck
            int index = 0;// throw the card at the top of the deck
            Card card = new Card((int)CardSet[index].CardSuit, (int)CardSet[index].CardValue);
            CardSet.RemoveAt(index);

            return card;
        }
        /// <summary>
        /// Method to play a card from the current deck
        /// </summary>
        public void PlayCard()
        {
            //this.Shuffle(); // Not sure if problem statement wants card to be shuffled everytime or to be shuffled at user request hence commenting
            Card hand = this.DrawCard();
            // Display card drawn
            Console.WriteLine("Your card is ::{0} of {1}", hand.CardValue, hand.CardSuit);

        }
        /// <summary>
        /// Shuffles the current deck
        /// </summary>
        public void ShuffleDeck()
        {
            this.Shuffle();
        }
        /// <summary>
        /// Resets and creates a new shuffled deck
        /// </summary>
        /// <returns>Returns a new deck of cards</returns>
        public Deck RestartGame()
        {
           return new Deck();
        }
    }
}
