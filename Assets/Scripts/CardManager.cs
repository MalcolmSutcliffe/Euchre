using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager instance;

    public GameObject cardPrefab;

    public List<GameObject> playerCards;

    public Sprite aceOfSpadesSprite;
    public Sprite nineOfSpadesSprite;
    public Sprite tenOfSpadesSprite;
    public Sprite jackOfSpadesSprite;
    public Sprite queenOfSpadesSprite;
    public Sprite kingOfSpadesSprite;

    public Sprite aceOfClubsSprite;
    public Sprite nineOfClubsSprite;
    public Sprite tenOfClubsSprite;
    public Sprite jackOfClubsSprite;
    public Sprite queenOfClubsSprite;
    public Sprite kingOfClubsSprite;

    public Sprite aceOfHeartsSprite;
    public Sprite nineOfHeartsSprite;
    public Sprite tenOfHeartsSprite;
    public Sprite jackOfHeartsSprite;
    public Sprite queenOfHeartsSprite;
    public Sprite kingOfHeartsSprite;

    public Sprite aceOfDiamondsSprite;
    public Sprite nineOfDiamondsSprite;
    public Sprite tenOfDiamondsSprite;
    public Sprite jackOfDiamondsSprite;
    public Sprite queenOfDiamondsSprite;
    public Sprite kingOfDiamondsSprite;

    void Awake()
    {
        if (instance == null){
            instance = this;
        }
        else{
            Destroy(this);
        }
    }

    public void DrawPlayerCards(Player player)
    {
        playerCards = new List<GameObject>();
        for (int i = 0; i < player.cardsInHand.Count; i++)
        {
            GameObject newCardObj = Instantiate(cardPrefab, this.transform);
            newCardObj.GetComponent<CardGameObject>().Initialize(player.cardsInHand[i]);
            newCardObj.transform.Translate(new Vector2(84*(i - ((float) player.cardsInHand.Count / 2.0f)), 0));
        }
    }

    public Sprite GetCardSprite(Card card)
    {
        if (card.suit == Card.Suit.Spade)
        {
            if (card.rank == Card.Rank.Ace)
                return aceOfSpadesSprite;
            if (card.rank == Card.Rank.Nine)
                return nineOfSpadesSprite;
            if (card.rank == Card.Rank.Ten)
                return tenOfSpadesSprite;
            if (card.rank == Card.Rank.Jack)
                return jackOfSpadesSprite;
            if (card.rank == Card.Rank.Queen)
                return queenOfSpadesSprite;
            if (card.rank == Card.Rank.King)
                return kingOfSpadesSprite;
        }
        if (card.suit == Card.Suit.Club)
        {
            if (card.rank == Card.Rank.Ace)
                return aceOfClubsSprite;
            if (card.rank == Card.Rank.Nine)
                return nineOfClubsSprite;
            if (card.rank == Card.Rank.Ten)
                return tenOfClubsSprite;
            if (card.rank == Card.Rank.Jack)
                return jackOfClubsSprite;
            if (card.rank == Card.Rank.Queen)
                return queenOfClubsSprite;
            if (card.rank == Card.Rank.King)
                return kingOfClubsSprite;
        }
        if (card.suit == Card.Suit.Heart)
        {
            if (card.rank == Card.Rank.Ace)
                return aceOfHeartsSprite;
            if (card.rank == Card.Rank.Nine)
                return nineOfHeartsSprite;
            if (card.rank == Card.Rank.Ten)
                return tenOfHeartsSprite;
            if (card.rank == Card.Rank.Jack)
                return jackOfHeartsSprite;
            if (card.rank == Card.Rank.Queen)
                return queenOfHeartsSprite;
            if (card.rank == Card.Rank.King)
                return kingOfHeartsSprite;
        }
        if (card.suit == Card.Suit.Diamond)
        {
            if (card.rank == Card.Rank.Ace)
                return aceOfDiamondsSprite;
            if (card.rank == Card.Rank.Nine)
                return nineOfDiamondsSprite;
            if (card.rank == Card.Rank.Ten)
                return tenOfDiamondsSprite;
            if (card.rank == Card.Rank.Jack)
                return jackOfDiamondsSprite;
            if (card.rank == Card.Rank.Queen)
                return queenOfDiamondsSprite;
            if (card.rank == Card.Rank.King)
                return kingOfDiamondsSprite;
        }
        return null;
    }
}
