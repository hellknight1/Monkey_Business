using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int SavedBananas;
    public int SavedCash;
    public int SavedBananaTrees;
    public int SavedStands;
    public int SaveValue;
    public int SavedBanRun;
    public int SavedStaRun;
    public GameObject AutoBanana;
    public GameObject AutoSell;
    public int SavedStandValue;
    public int SavedBananaTreeValue;
    public int Spinprice;
    void Start()
    {
        if(MainMenuOptions.isLoading == true)
        {
            SavedBananas=PlayerPrefs.GetInt("SavedBananas");
            GlobalBananas.BananaCount=SavedBananas;
            SavedCash=PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount=SavedCash;
            SavedBananaTrees=PlayerPrefs.GetInt("SavedBananaTrees");
            GlobalBananaTree.NumberOfTrees=SavedBananaTrees;
            SavedStands=PlayerPrefs.GetInt("SavedStands");
            GlobalStand.NumberOfStand=SavedStands;
            SaveValue=PlayerPrefs.GetInt("SaveValue");
            SaveGame.SaveValue = SaveValue;
            SavedBanRun=PlayerPrefs.GetInt("SavedBanRun");
            SavedStaRun=PlayerPrefs.GetInt("SavedStaRun");
            if(SavedBanRun == 1)
            {
                AutoBanana.SetActive(true);
            }
            if(SavedStaRun == 1)
            {
                AutoSell.SetActive(true);
            }
            SavedStandValue=PlayerPrefs.GetInt("SavedStandValue");
            GlobalStand.standValue = SavedStandValue;
            SavedBananaTreeValue=PlayerPrefs.GetInt("SavedBananaTreeValue");
            GlobalBananaTree.BananaTreeValue = SavedBananaTreeValue;
            Spinprice =PlayerPrefs.GetInt("SavedSpinCost");
            WheelOfFortune.SpinPrice = Spinprice;

        }
        
    }


}
