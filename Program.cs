using System;
using System.Collections.Generic;

namespace all_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranks = new List<string>() { "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "Jack", "Queen", "King", "Ace" };
            var suits = new List<string>() { "Clubs", "Spades", "Diamonds", "Hearts" };
            var deck = new List<string>();

            for (var rankIndex = 0; rankIndex < ranks.Count; rankIndex++)
            {
                for (var suitIndex = 0; suitIndex < suits.Count; suitIndex++)
                {
                    var currentRank = ranks[rankIndex];
                    var currentSuit = suits[suitIndex];
                    var currentCard = $"The {currentRank} of {currentSuit}";
                    deck.Add(currentCard);
                }
            }
        }
    }
}
