using System.Collections;
using System.Collections.Generic;

public struct Card {
    public enum Rank {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }

    public enum Suit {
        Club,
        Heart,
        Spade,
        Diamond,
    }
    public Rank rank {get; private set;}
    public Suit suit {get; private set;}

    public Card(Rank rank, Suit suit)
    {
        this.rank = rank;
        this.suit = suit;
    }
}
