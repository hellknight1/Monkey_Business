using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalBananaTree : MonoBehaviour
{
    public Button BananaTreeButton;
    public TextMeshProUGUI BananaTreeButtonText;
    public int CurrentCash;
    public static int BananaTreeValue = 20;
    public TextMeshProUGUI BananaTreeStats;
    public static int NumberOfTrees;
    public static int BananaPerSec;

    private void Update() 
    {
        CurrentCash = GlobalCash.CashCount;
        BananaTreeStats.text = "Banana Trees: " + NumberOfTrees + " @ " + BananaPerSec + " p/s";
        BananaTreeButtonText.text = "Buy Banana Tree - $" + BananaTreeValue;
        if(CurrentCash >= BananaTreeValue)
        {
            BananaTreeButton.interactable = true;
        }
        else
        {
            BananaTreeButton.interactable = false;
        }
    }
}
