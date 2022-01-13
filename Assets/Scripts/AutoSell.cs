using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public static bool SellingBananas;
    public static int SellIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        SellIncrease = GlobalStand.NumberOfStand;
        InternalIncrease = SellIncrease;
        GlobalStand.SellPerSec = InternalIncrease;
        if(SellingBananas == false)
        {
            SellingBananas = true;
            StartCoroutine(CreateTheBanana());
        }   
    }

    IEnumerator CreateTheBanana()
    {
        if(GlobalBananas.BananaCount >= InternalIncrease)
        {
            yield return new WaitForSeconds(1);
            GlobalBananas.BananaCount -= InternalIncrease;
            GlobalCash.CashCount += InternalIncrease;
            SellingBananas = false;
        }
        else
        {
            yield return new WaitForSeconds(1);
            SellingBananas = false;
        }
    }
}
