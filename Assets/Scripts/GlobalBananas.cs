using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalBananas : MonoBehaviour
{
    public static int BananaCount;
    public TextMeshProUGUI BananaDisplay;
    public int InternalBananas;
    
    void Update()
    {
        InternalBananas = BananaCount;
        BananaDisplay.text = "Total Bananas: " + InternalBananas;
    }
}
