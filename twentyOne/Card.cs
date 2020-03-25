using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace twentyOne
{
   public class Card
    {
        //public Card()                       // Constructor
        //{
        //    Suit = "Spades";
        //    Face = "Two"; 
        //}
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    public enum Suit    // example of an enum
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
