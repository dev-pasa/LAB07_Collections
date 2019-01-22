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
        public void Add1()
        {
            Deck<Card> myDeck = new Deck<Card>();

            Card twoOfSpades = new Card(Suit.Spades, Value.Two);
            
            myDeck.Add(twoOfSpades );
            

            Assert.Equal(1, myDeck.count);
        }

        /// <summary>
        /// Tests if card if added to the list
        /// </summary>
        [Fact]
        public void Add2()
        {
            Deck<Card> myDeck = new Deck<Card>();

            Card c1 = new Card(Suit.Club, Value.Ace);
            Card c3 = new Card(Suit.Spades, Value.Two);

            myDeck.Add(c1);
            myDeck.Add(c3);

            Assert.Equal(2, myDeck.count);
        }
        [Fact]
        public void Add3()
        {
            Deck<Card> myDeck = new Deck<Card>();

            Card c2 = new Card(Suit.Spades, Value.Two);
            Card c1 = new Card(Suit.Club, Value.Ace);
            Card c3 = new Card(Suit.Spades, Value.Two);

            myDeck.Add(c1);
            myDeck.Add(c2);
            myDeck.Add(c3);

            Assert.Equal(3, myDeck.count);
        }

        /// <summary>
        /// Tests if card if removed from the list
        /// </summary>
        [Fact]
        public void Remove1()
        {
            Card c2 = new Card(Suit.Spades, Value.Two);
            Card c1 = new Card(Suit.Club, Value.Ace);
            Card c3 = new Card(Suit.Spades, Value.Two);
            Deck<Card> myDeck = new Deck<Card>();

            Card[] cards = new Card[] { c1, c2, c3 };
            for (int i = 0; i < cards.Length; i++)
            {
                myDeck.Add(cards[i]);
            }
            myDeck.Remove(c1);

            Assert.Equal(2, myDeck.count);
        }

        /// <summary>
        /// Tests if card if removed from the list
        /// </summary>
        [Fact]
        public void Remove2()
        {
            Card c2 = new Card(Suit.Spades, Value.Two);
            Card c1 = new Card(Suit.Club, Value.Ace);
            Card c3 = new Card(Suit.Spades, Value.Two);
            Deck<Card> myDeck = new Deck<Card>();

            Card[] cards = new Card[] { c1, c2, c3 };
            for (int i = 0; i < cards.Length; i++)
            {
                myDeck.Add(cards[i]);
            }
            myDeck.Remove(c1);
            myDeck.Remove(c2);

            Assert.Equal(1, myDeck.count);
        }

        /// <summary>
        /// Tests if card if removed from the list
        /// </summary>
        [Fact]
        public void Remove3()
        {
            Card c2 = new Card(Suit.Spades, Value.Two);
            Card c1 = new Card(Suit.Club, Value.Ace);
            Card c3 = new Card(Suit.Spades, Value.Two);
            Deck<Card> myDeck = new Deck<Card>();

            Card[] cards = new Card[] { c1, c2, c3 };
            for (int i = 0; i < cards.Length; i++)
            {
                myDeck.Add(cards[i]);
            }
            myDeck.Remove(c1);
            myDeck.Remove(c2);
            myDeck.Remove(c3);
            Assert.Equal(0, myDeck.count);
        }

        [Fact]
        public void SuiteCard1()
        {
            Card c2 = new Card(Suit.Spades, Value.Two);
            
            Assert.Equal("Spades", c2.Suit.ToString());
        }
        [Fact]
        public void SuiteCard2()
        {
            Card c2 = new Card(Suit.Hearts, Value.Ace);

            Assert.Equal("Hearts", c2.Suit.ToString());
        }
        [Fact]
        public void SuiteCard3()
        {
            Card c2 = new Card(Suit.Club, Value.Eight);

            Assert.Equal("Club", c2.Suit.ToString());
        }

        [Fact]
        public void CardValue1()
        {
            Card c2 = new Card(Suit.Spades, Value.Two);

            Assert.Equal("Two", c2.Value.ToString());
        }
        [Fact]
        public void SuiteValue2()
        {
            Card c2 = new Card(Suit.Hearts, Value.Ace);

            Assert.Equal("Ace", c2.Value.ToString());
        }
        [Fact]
        public void SuiteValue3()
        {
            Card c2 = new Card(Suit.Club, Value.Eight);

            Assert.Equal("Eight", c2.Value.ToString());
        }

    }
}
