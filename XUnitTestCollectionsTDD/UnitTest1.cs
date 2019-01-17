using System;
using Xunit;
using Collections;
//using Collections.Classes;

namespace XUnitTestCollectionsTDD
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests if card if added to the list
        /// </summary>
        [Fact]
        public void InTheList()
        {
            Deck<Card> myDeck = new Deck<Card>();
            Card twoOfSpades = new Card(Suit.Spades, Value.Two);
            Card twoOfHeart = new Card(Suit.Hearts, Value.Two);
            myDeck.Add(twoOfSpades );
            myDeck.Add(twoOfHeart );
            
        }
    }


   }
