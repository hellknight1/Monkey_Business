using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoBanana;
    public GameObject AutoSell;
    public AudioSource Playsound;
    public void StartAutoBananaSell()
    {
        Playsound.Play();
        AutoSell.SetActive(true);
        GlobalCash.CashCount -= GlobalStand.standValue;
        GlobalStand.standValue *= 2;
        GlobalStand.NumberOfStand += 1;
    }

    public void StartAutoBanana()
    {
        Playsound.Play();
        AutoBanana.SetActive(true);
        GlobalCash.CashCount -= GlobalBananaTree.BananaTreeValue;
        GlobalBananaTree.BananaTreeValue *= 2;
        GlobalBananaTree.NumberOfTrees += 1;
    }

}
