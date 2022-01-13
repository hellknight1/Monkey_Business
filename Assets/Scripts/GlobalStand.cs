using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalStand : MonoBehaviour
{
    public Button StandButton;
    public TextMeshProUGUI StandButtonText;
    public int CurrentCash;
    public static int standValue = 20;
    public TextMeshProUGUI StandsDisplay;
    public static int NumberOfStand;
    public static int SellPerSec;

    private void Update() 
    {
        CurrentCash = GlobalCash.CashCount;
        StandsDisplay.text = "Banana Stands: " + NumberOfStand + " @ " + SellPerSec + " p/s";
        StandButtonText.text = "Buy Banana Stand - $" + standValue;
        if(CurrentCash >= standValue)
        {
            StandButton.interactable = true;
        }
        else
        {
            StandButton.interactable = false;
        }
    }
}
