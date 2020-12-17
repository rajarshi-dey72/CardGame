using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        /// <summary>
        /// Main method of the program 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("***********WELCOME TO CARD GAME*************");
            Console.WriteLine("Please see the game options below");
            Console.WriteLine(" 1. Play a card\n 2. Shuffle the deck\n 3. Restart\n 4. Exit");
            Console.WriteLine("Please select an option to start the game");
            PlayGame();
            Console.WriteLine("Please hit any key to exit....");
            Console.ReadKey();
        }
        /// <summary>
        /// Card game method which calls the respective game methods
        /// </summary>
        static void PlayGame()
        {
            int gameOption = int.MinValue;
            try
            {
                Deck deck = new Deck();
                while (gameOption != (int)GameOption.Exit)
                {
                    //Console.WriteLine("Number of cards left in the deck ::"+ deck.CardSet.Count);
                    if (deck.CardSet.Count < 1)
                    {
                        Console.WriteLine("All cards have been played... restarting the card....");
                        deck = deck.RestartGame();
                    }
                    Console.WriteLine("Enter your Choice");
                    string input = Console.ReadLine();
                    bool isProperInput = int.TryParse(input, out gameOption);
                    if (!isProperInput)
                    {
                        Console.WriteLine("Not a valid option.. Please enter a valid input between 1 and 4");
                        continue;
                    }
                    else
                    {
                       
                        switch (gameOption)
                        {
                            case (int)GameOption.PlayCard:
                                deck.PlayCard();
                                break;
                            case (int)GameOption.ShuffleDeck:
                                Console.WriteLine("Shuffling the deck...");
                                deck.ShuffleDeck();
                                break;
                            case (int)GameOption.RestartGame:
                                Console.WriteLine("Restarting the game...");
                                deck = deck.RestartGame();
                                break;
                            case (int)GameOption.Exit:
                                Console.WriteLine("***********THANK YOU FOR PLAYING***********");
                                return;
                            default:
                                Console.WriteLine("Not a valid option");
                                break;
                        }
                                
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a proper option... Restarting the game..");
                PlayGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occurred.. Restarting the game");
                PlayGame();
            }
        }
        /// <summary>
        /// Game Options enum
        /// </summary>
        public enum GameOption
        {
            PlayCard = 1,
            ShuffleDeck = 2,
            RestartGame = 3,
            Exit = 4
        }
    }
}
