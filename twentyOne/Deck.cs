using System;
using System.Collections.Generic;
using System.Text;

namespace twentyOne
{
    public class Deck
    {
        public Deck()           //Constructor. As soon as Deck is created, do the code below:
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five",
                "Six", "Seven", "Eight", "Nine",
                "Ten", "Jack", "Queen", "King",
                "Ace",
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)   // Method for shuffling the deck
        {
            
            for (int i = 0; i < times; i++)
            {
                
                List<Card> TempList = new List<Card>();     // Create a new temp list that will hold the new shuffled cards
                Random random = new Random();               // Random method stored in random variable

                while (Cards.Count > 0)                   // while there are at least 1 card in deck do this:
                {
                    int randomIndex = random.Next(0, Cards.Count);         // assign to int randomIndex a new random card
                    TempList.Add(Cards[randomIndex]);                      // add new random cards to TempList
                    Cards.RemoveAt(randomIndex);                           // remove cards from original list to fullfil while statement
                }
                Cards = TempList;                                          // assign new list to Templist
            }                                                    

        }
    }
}
