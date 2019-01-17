using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Card
    {
        public Suit Suit { get; set; }

        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

    }

    /// <summary>
    /// create a suit of cards
    /// </summary>
    public enum Suit
    {
        Spades,
        Hearts,
        Diamonds,
        Club
    }

    /// <summary>
    /// create a enum of values of cards
    /// </summary>
    public enum Value
    {
        Ace = 1,
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
        King
    }

}
