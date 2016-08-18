using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{

    //Prefabs
    public Sprite template;

    //Active Objects
    GameObject deck;
    GameObject discard;
    GameObject player1;
    GameObject player2;
    

    public int activePlayer = 1;

    // Use this for initialization
    void Start()
    {
        setUp();
        for (int i = 0; i < 10; i++)
        {
            player1.GetComponent<Player>().DrawCard(deck);
            player2.GetComponent<Player>().DrawCard(deck);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void setUp()
    {
        player1 = new GameObject(); player1.AddComponent<Player>(); player1.GetComponent<Player>().playerNumber = 1; player1.name = "Player 1";
        player2 = new GameObject(); player2.AddComponent<Player>(); player2.GetComponent<Player>().playerNumber = 2; player2.name = "Player 2";

        deck = new GameObject(); deck.name = "Deck";
        discard = new GameObject(); discard.name = "Discard";
        string[] suit = new string[4] { "H", "C", "D", "S" };
        int j = 2;
        int k = 0;
        for (int i = 0; i < 48; i++)
        {
            GameObject newCard = new GameObject();
            newCard.AddComponent<Card>(); newCard.AddComponent<SpriteRenderer>(); newCard.AddComponent<Text>();
            newCard.GetComponent<Card>().index = j; newCard.GetComponent<Card>().suit = k;
            newCard.GetComponent<SpriteRenderer>().sprite = template;
            newCard.GetComponent<Text>().text = suit[k] + " " + j; newCard.GetComponent<Text>().color = Color.black;
            newCard.name = suit[k] + " " + j;
            newCard.transform.SetParent(deck.transform);
            j++;
            if (j > 13)
            {
                j = 2;
                k++;
            }
        }
    }
}
