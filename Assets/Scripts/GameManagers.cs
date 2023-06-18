using UnityEngine;
using UnityEngine.UI;

public class GameManagers : MonoBehaviour
{
    public CardShuffler cardShuffler;

    public GameObject blackbox;
    public Image resultImage;
    public Button cardA;
    public Button cardB;
    public Button cardC;

    public Sprite winSprite; // Assign the win sprite in the Inspector
    public Sprite loseSprite; // Assign the lose sprite in the Inspector

    public bool gameEnded = false;

    private void Start()
    {
        cardA.onClick.AddListener(() => OnCardClick(cardA));
        Debug.Log(cardA.onClick.GetPersistentEventCount());
        cardB.onClick.AddListener(() => OnCardClick(cardB));
        cardC.onClick.AddListener(() => OnCardClick(cardC));
    }

    private void Update()
    {
        if (IsGameEnded())
        {
            blackbox.gameObject.SetActive(false);
        }
    }
    private void OnCardClick(Button selectedCard)
    {
        Debug.Log("clicked");
        if (gameEnded)
        {
            return; // Ignore clicks after the game has ended
        }

        CardButton cardButton = selectedCard.GetComponent<CardButton>();
        
        if (cardButton != null)
        {
            cardButton.ShowCardResult(cardButton.isCorrectCard);
        }
    }

    public bool IsGameEnded()
    {
        return gameEnded;
    }

    public void SetGameEnded(bool value)
    {
        gameEnded = value;
    }

    public Sprite GetWinSprite()
    {
        return winSprite;
    }

    public Sprite GetLoseSprite()
    {
        return loseSprite;
    }
    public void Trigger_card()
    {
         cardShuffler.Trigger_shuffle();
    }
}