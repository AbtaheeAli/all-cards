using System;
using System.Collections.Generic;
using System.Linq;

namespace all_cards
{
    class Program
    {
        static void Main(string[] args)
        {
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

            for (var firstIndex = n - 1; firstIndex >= 1; firstIndex--)
            {
                Random rnd = new Random();

                var secondIndex = rnd.Next(firstIndex);

                var firstValue = deck[firstIndex];

                var secondValue = deck[secondIndex];

                deck[firstIndex] = secondValue;
                deck[secondIndex] = firstValue;
            }

            Console.WriteLine(deck[0]);
            Console.WriteLine(deck[1]);
        }
    }
}
