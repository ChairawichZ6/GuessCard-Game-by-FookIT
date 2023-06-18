using UnityEngine;

public class GameManagers : MonoBehaviour
{
    public Card[] cards; // An array to store the three cards
    public Card hintCard; // The hint card


    private bool hintOpened = false; // Flag to track if the hint card is opened

    private void Start()
    {
        // Initialize the cards and hint card
        cards = new Card[3];
        for (int i = 0; i < 3; i++)
        {
            cards[i] = new Card(); // Initialize each card
        }
        hintCard = new Card(); // Initialize the hint card
        
    }
    void ShuffleCards()
    {
        System.Random rng = new System.Random();
        cards = new Card[3];
        for (int i = 0; i < 3; i++)
        {
            cards[i] = new Card(); // Initialize each card
        }
        hintCard = new Card(); // Initialize the hint card

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            // Check if a card is clicked
            if (Physics.Raycast(ray, out hit))
            {
                Card clickedCard = hit.collider.GetComponent<Card>();
                
                if (clickedCard != null)
                {
                    if (!hintOpened)
                    {
                        // Open the hint card and reveal the information
                        hintCard.OpenCard();
                        Debug.Log("Hint: " + hintCard.GetCardInfo());
                        hintOpened = true;
                    }
                    else
                    {
                        // Show the selected card's information
                        Debug.Log("Selected Card: " + clickedCard.GetCardInfo());
                    }
                }
            }
        }
    }
}
