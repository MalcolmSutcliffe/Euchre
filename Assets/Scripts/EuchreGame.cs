using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EuchreGame : MonoBehaviour
{    
    private EuchreDeck euchreDeck;
    private Player player1;
    private Player player2;
    private Player player3;
    private Player player4;
    private int team1Score;
    private int team2Score;

    void Start()
    {
        
    }

    void Awake()
    {
        NewGame();
    }

    void Update()
    {
        
    }

    public void NewGame()
    {
        euchreDeck = new EuchreDeck();
        euchreDeck.ShuffleDeck();
        player1 = new Player();
        player2 = new Player();
        player3 = new Player();
        player4 = new Player();
        team1Score = 0;
        team2Score = 0;
        DealCards();
        CardManager.instance.DrawPlayerCards(player1);
    }

    private void DealCards()
    {
        for (int i = 0; i < 5; i++)
        {
            player1.GetCard(euchreDeck.GetTopCard());
            player2.GetCard(euchreDeck.GetTopCard());
            player3.GetCard(euchreDeck.GetTopCard());
            player4.GetCard(euchreDeck.GetTopCard());
        }
    }
}
