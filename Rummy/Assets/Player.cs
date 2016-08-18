using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public int playerNumber;

    // Use this for initialization
    void Start()
    {
        if (playerNumber == 1)
        {
            transform.position = new Vector2(.0065f*Screen.width, -.008f * Camera.main.);
        }
        else
        {
            transform.position = new Vector2(0, .008f * Screen.height);
        }
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).position = new Vector2(i * .002f * Screen.width - transform.position.x, transform.position.y);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DrawCard(GameObject currentDeck)
    {
        int randCard = Random.Range(0, currentDeck.transform.childCount);
        currentDeck.transform.GetChild(randCard).SetParent(transform);
    }

    public void DiscardCard(int index, GameObject discard)
    {
        transform.GetChild(index).SetParent(discard.transform);
    }

}
