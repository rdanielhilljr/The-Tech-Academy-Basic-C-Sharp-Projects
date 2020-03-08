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
    }
}
