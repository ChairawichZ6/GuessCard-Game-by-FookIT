using UnityEngine;

public class CardShuffler : MonoBehaviour
{
    public RectTransform[] cards;
    private Vector2[] startingPositions;
    public GameObject CardA;
    public GameObject CardB;
    public GameObject CardC;

    private void StoreStartingPositions()
    {
        startingPositions = new Vector2[3];
        startingPositions[0] = CardA.transform.position;
        startingPositions[1] = CardB.transform.position;
        startingPositions[2] = CardC.transform.position;
    }

    private void ShuffleCards()
    {
        Vector2 tempPosition = startingPositions[0];
        startingPositions[0] = startingPositions[2];
        startingPositions[2] = tempPosition;
    }

    private void UpdateCardPositions()
    {
        int n = cards.Length;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);

            Vector2 tempPosition = cards[k].anchoredPosition;
            cards[k].anchoredPosition = cards[n].anchoredPosition;
            cards[n].anchoredPosition = tempPosition;
        }
        }
    public void Trigger_shuffle()
    {
        StoreStartingPositions();
        ShuffleCards();
        UpdateCardPositions();
        Debug.Log("full");
    }
}
