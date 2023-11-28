using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Player
{
    public List<Card> cardsInHand;
    public Player()
    {
        cardsInHand = new List<Card>();
    }

    public Card PlayCard()
    {
        // plays last card
        Card playedCard = cardsInHand.LastOrDefault();
        cardsInHand.RemoveAt(cardsInHand.Count-1);
        return playedCard;
    }

    public void GetCard(Card card)
    {
        if (cardsInHand.Count >= 5)
        {
            return;
        }
        cardsInHand.Add(card);
    }
}