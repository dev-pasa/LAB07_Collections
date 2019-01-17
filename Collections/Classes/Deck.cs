using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{

    public class Deck<T> : IEnumerable<T>
    {
        T[] Cards = new T[5];

        public int currentIndex = 0;

        /// <summary>
        /// add card to the deck
        /// </summary>
        /// <param name="card"></param>
        public void Add(T card)
        {
            if (currentIndex > Cards.Length - 1)
            {
                Array.Resize(ref Cards, Cards.Length * 2);
            }
            Cards[currentIndex] = card;
            currentIndex++;
        }

         /// <summary>
        /// Remove the card from the deck
        /// </summary>
        /// <param name="card"></param>
        public void Remove(T card)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (Cards[i].Equals(card))
                {
                    for (int j = i; j < currentIndex - i - 1; j++)
                    {
                        Cards[j] = Cards[j + 1];
                    }
                    currentIndex--;
                }
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            // Vinicio - this is a basic implementation of yield
            //yield return internalItems[0];
            //yield return internalItems[2];

            for (int i = 0; i < currentIndex; i++)
            {
                yield return Cards[i];
            }
        }

        // Vinicio - mainly required for C# 1
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}