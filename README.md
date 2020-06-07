# all_cards

I created a deck of cards using the following information:

- The deck of cards contains 52 unique cards
- All the cards are represented as as string
- There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
- There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10",
  "Jack", "Queen", and "King"

To shuffle the cards, I implemented the following:

- The Fisher–Yates shuffle algorithm
- The shuffling algorithm starts with the last element in the deck of cards and swaps it with a randomly selected element that comes before it. This continues downward through the elements towards the first element

Two cards are dealt at random and shown on the console
