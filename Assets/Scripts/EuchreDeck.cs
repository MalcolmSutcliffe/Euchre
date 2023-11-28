using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class EuchreDeck
{
    public static List<Card.Rank> EUCHRE_RANKS = new List<Card.Rank> {Card.Rank.Nine, Card.Rank.Ten, Card.Rank.Jack, Card.Rank.Queen, Card.Rank.King, Card.Rank.Ace};
    public static List<Card.Suit> EUCHRE_SUITS = new List<Card.Suit> {Card.Suit.Club, Card.Suit.Heart, Card.Suit.Spade, Card.Suit.Diamond};
    List<Card> cards;

    public EuchreDeck()
    {
        this.cards = new List<Card>();
        foreach (var suit in EUCHRE_SUITS)
        {
            foreach (var rank in EUCHRE_RANKS){
                this.cards.Add(new Card(rank, suit));
            }
        }
    }

    public void ShuffleDeck()
    {
       cards.Shuffle();
    }

    public Card GetTopCard()
    {
        // returns the last card in the card list and removes it from the deck
        Card topCard = this.cards.LastOrDefault();
        this.cards.RemoveAt(this.cards.Count-1);
        return topCard;
    }
}