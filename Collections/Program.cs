using System;
using System.Reflection;
using Collections;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck<Card> myDeck = new Deck<Card>();
            Card c1 = new Card(Suit.Club, Value.Ace);
            Card c3 = new Card(Suit.Spades, Value.Two);
            Card c4 = new Card(Suit.Hearts, Value.Four);
            Card c5 = new Card(Suit.Diamonds, Value.Jack);
            Card c6 = new Card(Suit.Diamonds, Value.King);
            Card c2 = new Card(Suit.Spades, Value.Queen);
            Card c7 = new Card(Suit.Club, Value.Eight);
            Card c8 = new Card(Suit.Hearts, Value.Ace);
            Card c9 = new Card(Suit.Hearts, Value.Four);
            Card c10 = new Card(Suit.Club, Value.Five);

            Card[] cards = new Card[] { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 };
            for (int i = 0; i < cards.Length; i++)
            {
                myDeck.Add(cards[i]);
            }

            Console.WriteLine("The cards in your deck are: ");
            PrintDeck(myDeck);


            NextStep("Remove Club of Ace");
            myDeck.Remove(c1);
            PrintDeck(myDeck);

            Card c11 = new Card(Suit.Hearts, Value.Queen);
            NextStep("Add Queen of Hearts");
            Console.WriteLine();
            myDeck.Add(c11);
            PrintDeck(myDeck);

        }


        /// <summary>
        /// Print the deck of cards
        /// </summary>
        /// <param name="mydeck"></param>
        public static void PrintDeck(Deck<Card> mydeck)
        {

            foreach (Card card in mydeck)
            {

                if (mydeck != null)
                {
                    Console.WriteLine($"{card.Value} of {card.Suit}");
                }
            }
        }



        /// <summary>
        /// What is to happen next
        /// </summary>
        /// <param name="step"></param>
        public static void NextStep(string step)
        {
            Console.WriteLine();
            Console.WriteLine($"#####   Hit <Enter> to {step}   ##### ");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
