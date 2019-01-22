using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{

    public class Deck<T> : IEnumerable<T>
    {
        T[] Cards = new T[5];

        public int count = 0;

        /// <summary>
        /// add card to the deck
        /// </summary>
        /// <param name="card"></param>
        public void Add(T card)
        {
            if (count == Cards.Length)
            {
                Array.Resize(ref Cards, Cards.Length * 2);
            }
            Cards[count] = card;
            count++;
        }

        /// <summary>
        /// Remove the card from the deck
        /// </summary>
        /// <param name="card"></param>
        //public void Remove(T card)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (Cards[i].Equals(card))
        //        {
        //            for (int j = i; j < count - i - 1; j++)
        //            {
        //                Cards[j] = Cards[j + 1];
        //            }
        //            count--;
        //        }
        //    }
        //}

        /// <summary>
        /// Remove the card from the deck
        /// </summary>
        /// <param name="card"></param>
        public void Remove(T item)
        {
            T[] temp = new T[(count - 1)];
            int tempcount = 0;

            foreach (T card in Cards)
            {
                if (card != null)
                {
                    if (!card.Equals(item))
                    {
                        temp[tempcount] = card;
                        tempcount++;
                    }
                }

            }

            Cards = temp;
            count--;
        }

        //Amanda's code
        //public void Remove(T item)
        //{
        //    T[] temp = new T[(count - 1)];
        //    int tempcount = 0;

        //    foreach(T card in cards)
        //    {
        //        if(card != null)
        //        {
        //            if (!card.Equals(item))
        //            {
        //                temp[tempcount] = card;
        //                tempcount++;
        //            }
        //        }
        //    }
        //    Cards = temp;
        //    count--;
        //}

        public IEnumerator<T> GetEnumerator()
        {
            // Vinicio - this is a basic implementation of yield
            //yield return internalItems[0];
            //yield return internalItems[2];

            for (int i = 0; i < count; i++)
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