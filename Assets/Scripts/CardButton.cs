using UnityEngine;
using UnityEngine.UI;

public class CardButton : MonoBehaviour
{
    public GameManagers gameManager;
    public Image resultImage;
    public bool isCorrectCard;

    public Button Button_play;
    

    public void ShowCardResult(bool isCorrect)
    {
        Debug.Log("clicked");
        if (isCorrect)
        {
            resultImage.sprite = gameManager.GetWinSprite();
            Debug.Log("You win!");
        }
        else
        {
            resultImage.sprite = gameManager.GetLoseSprite();
            Debug.Log("You lose!");
        }

        resultImage.gameObject.SetActive(true);
        gameManager.SetGameEnded(true);
    }
}
