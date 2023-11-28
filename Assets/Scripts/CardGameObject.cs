using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardGameObject : MonoBehaviour
{
    private Image cardImage;
    private Card card;

    void Awake()
    {
        cardImage = GetComponent<Image>();
    }

    public void Initialize(Card card)
    {
        this.card = card;
        Debug.Log(CardManager.instance.GetCardSprite(card));
        this.cardImage.sprite = CardManager.instance.GetCardSprite(card);
    }
}
