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

            Console.WriteLine("The cards in dealer's deck are: ");
            PrintDeck(myDeck);

            NextStep("Remove Club of Ace");
            myDeck.Remove(c1);
            PrintDeck(myDeck);

            Card c11 = new Card(Suit.Hearts, Value.Queen);
            NextStep("Add Queen of Hearts");

            myDeck.Add(c11);
            PrintDeck(myDeck);

            Console.WriteLine();
            Console.WriteLine($"The number of cards in the dealer's deck is {myDeck.count}");

            NextStep("Add  or Remove");
            Deal();

           
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
      
        /// <summary>
        /// create a deal method
        /// </summary>
        public static void Deal()
        {
            Deck<Card> myDeck2 = new Deck<Card>();
            Deck<Card> player1 = new Deck<Card>();
            Deck<Card> player2 = new Deck<Card>();

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
            //Card[] cards = new Card[] { c1, c2, c3, c4, c5, c9, c10 };
            for (int i = 0; i < cards.Length; i++)
            {
                myDeck2.Add(cards[i]);
            }

            Console.WriteLine($"The number of cards in Player 1 deck is {player1.count}");
            Console.WriteLine($"The number of cards in Player 2 deck is {player2.count}");
            Console.WriteLine();
            Console.WriteLine("The cards in dealer deck are: ");
            PrintDeck(myDeck2);
            NextStep("Making changes");

            myDeck2.Remove(c1);
            myDeck2.Remove(c3);
            myDeck2.Remove(c5);
            myDeck2.Remove(c7);
            myDeck2.Remove(c9);

            player1.Add(c1);
            player1.Add(c3);
            player1.Add(c5);
            player1.Add(c7);
            player1.Add(c9);

            myDeck2.Remove(c2);
            myDeck2.Remove(c4);
            myDeck2.Remove(c6);
            myDeck2.Remove(c8);
            myDeck2.Remove(c10);

            player2.Add(c2);
            player2.Add(c4);
            player2.Add(c6);
            player2.Add(c8);
            player2.Add(c10);
   
            Console.WriteLine($"The number of cards in Player 1 deck is {player1.count}");
            Console.WriteLine("The cards in player 1 deck are: ");
            PrintDeck(player1);

            Console.WriteLine();
            Console.WriteLine($"The number of cards in Player 2 deck is {player2.count}");
            Console.WriteLine("The cards in player 2 deck are: ");
            PrintDeck(player2);

            Console.WriteLine();
            Console.WriteLine($"The number of cards in Player 2 deck is {myDeck2.count}");
            Console.WriteLine("The cards in dealer deck are: ");
            PrintDeck(myDeck2);
        }

}
  
}
