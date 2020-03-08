using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck: deck, out timesShuffled, 3);       // Calling Shuffle method


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled {0}", timesShuffled);
            Console.ReadLine();
              

            
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)   // Method for shuffling the deck
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();     // Create a new temp list that will hold the new shuffled cards
                Random random = new Random();               // Random method stored in random variable

                while (deck.Cards.Count > 0)                   // while there are at least 1 card in deck do this:
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);         // assign to int randomIndex a new random card
                    TempList.Add(deck.Cards[randomIndex]);                      // add new random cards to TempList
                    deck.Cards.RemoveAt(randomIndex);                           // remove cards from original list to fullfil while statement
                }
                deck.Cards = TempList;                                          // assign new list to Templist
            }
           
            return deck;                                                    // return the new deck to deck

        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++){

        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
            

    }
}
