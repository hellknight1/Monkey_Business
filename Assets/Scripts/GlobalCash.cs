using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalCash : MonoBehaviour
{
    public static int CashCount;
    public TextMeshProUGUI CashDisplay;
    public int InternalCash = 0;
    
    void Update()
    {
        InternalCash = CashCount;
        CashDisplay.text = "Total $Cash$: " + InternalCash;
    }
}
