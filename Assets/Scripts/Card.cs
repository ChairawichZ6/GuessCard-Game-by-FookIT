using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Card : MonoBehaviour
{
    public string cardInfo; // Information about the card

    private bool isOpen = false;

    public void OpenCard()
    {
        if (isOpen)
        {
            return; // Ignore opening the card if it's already open
        }

        isOpen = true;
        Debug.Log("Card opened: " + cardInfo);
    }

    public string GetCardInfo()
    {
        return cardInfo;
    }
}
