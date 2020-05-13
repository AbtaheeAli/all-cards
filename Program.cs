using System;
using System.Collections.Generic;
using System.Linq;

namespace all_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //declared ranks and suits for deck
            var ranks = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            var suits = new List<string>() { "Clubs", "Spades", "Diamonds", "Hearts" };
            var deck = new List<string>();

            for (var rankIndex = 0; rankIndex < ranks.Count(); rankIndex++)
            {
                for (var suitIndex = 0; suitIndex < suits.Count(); suitIndex++)
                {
                    var currentRank = ranks[rankIndex];
                    var currentSuit = suits[suitIndex];
                    var currentCard = $"The {currentRank} of {currentSuit}";
                    deck.Add(currentCard);
                }
            }
            var n = 52;
            // for firstIndex from n - 1 down to 1 do:
            for (var firstIndex = n - 1; firstIndex >= 1; firstIndex--)
            {
                Random rnd = new Random();
                //   secondIndex = random integer that is greater than or equal to 0 and LESS than firstIndex
                var secondIndex = rnd.Next(firstIndex);
                //   Now swap the values at firstIndex and secondIndex by doing this:
                //     firstValue = the value from items[firstIndex]
                var firstValue = deck[firstIndex];

                //     secondValue = the value from items[secondIndex]
                var secondValue = deck[secondIndex];
                //     items[firstIndex] = secondValue
                deck[firstIndex] = secondValue;
                //     items[secondIndex] = firstValue
                deck[secondIndex] = firstValue;
            }



        }
    }
}
