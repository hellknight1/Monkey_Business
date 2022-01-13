using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveGame : MonoBehaviour
{
    public int SaveGameCash;
    public static int SaveValue = 10;
    public Button savebutton;
    public TextMeshProUGUI savetext;
    public int saveStand;
    public int saveBananaTrees;

        void Update()
    {
        savetext.text ="Save Game Costs: $" + SaveValue;
        SaveGameCash = GlobalCash.CashCount;
        if(SaveGameCash >= SaveValue)
        {
            savebutton.interactable = true;
        }
        else
        {
            savebutton.interactable = false;
        }
    }
    public void SaveTheGame()
    {
        if(GlobalBananaTree.NumberOfTrees > 0)
        {
            saveBananaTrees = 1;
        }
        else saveBananaTrees = 0;
        if(GlobalStand.NumberOfStand > 0)
        {
            saveStand = 1;
        }
        else saveStand=0;
        GlobalCash.CashCount -= SaveValue;
        PlayerPrefs.SetInt("SavedBananas",GlobalBananas.BananaCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.CashCount);
        PlayerPrefs.SetInt("SavedBananaTrees", GlobalBananaTree.NumberOfTrees);
        PlayerPrefs.SetInt("SavedStands", GlobalStand.NumberOfStand);
        SaveValue *= 2;
        PlayerPrefs.SetInt("SaveValue", SaveValue);
        PlayerPrefs.SetInt("SavedBanRun", saveBananaTrees);
        PlayerPrefs.SetInt("SavedStaRun", saveStand);
        PlayerPrefs.SetInt("SavedStandValue", GlobalStand.standValue);
        PlayerPrefs.SetInt("SavedBananaTreeValue", GlobalBananaTree.BananaTreeValue);
        PlayerPrefs.SetInt("SavedSpinCost", WheelOfFortune.SpinPrice);
    }
}
