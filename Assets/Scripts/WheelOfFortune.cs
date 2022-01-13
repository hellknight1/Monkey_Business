using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using EasyUI.PickerWheelUI;
using TMPro;

public class WheelOfFortune : MonoBehaviour
{
    [SerializeField] private Button uiSpinButton;
    [SerializeField] private TextMeshProUGUI UiSpinButtonText;
    [SerializeField] private PickerWheel pickerWheel;
    public static int SpinPrice;
    private int TempSpinPrice;
    private int reward;
    private int number;

    private void Start() {
        UiSpinButtonText.text = "Spin Price: $" + SpinPrice;
        uiSpinButton.onClick.AddListener(() => {
            reward = SpinPrice;
            GlobalCash.CashCount -= SpinPrice;
            SpinPrice *= 2;
            uiSpinButton.interactable = false;
            UiSpinButtonText.text = "Spinning";
            pickerWheel.OnSpinStart (() => {
                Debug.Log ("spin Started..");
            });
            pickerWheel.OnSpinEnd (WheelPiece => {
                Debug.Log ("Spin End: " + WheelPiece.Label+ " Amount:" + WheelPiece.Amount);
                uiSpinButton.interactable = true;
                UiSpinButtonText.text = "Spin Price: $" + SpinPrice;
                number = WheelPiece.Amount;
                if(number == 1)
                {
                    reward *= 2;
                    GlobalBananas.BananaCount += reward;
                }
                else if(number == 2)
                {
                    reward *= 2; 
                    GlobalCash.CashCount += reward;
                }
                else if(number == 3)
                {
                    reward *= 2;
                    GlobalCash.CashCount -= reward;
                }
                else if(number == 4)
                {
                    reward *= 50;
                    GlobalCash.CashCount += reward;
                }
                else if(number == 5)
                {
                    reward *= 2;
                    GlobalCash.CashCount -= reward;
                }
                else if(number == 6)
                {
                    reward *= 5;
                    GlobalBananas.BananaCount += reward;
                }
                else if(number == 7)
                {
                    reward *= 5;
                    GlobalCash.CashCount += reward;
                }
                else if(number == 8)
                {
                   StartCoroutine(SpinAgain());
                }
            });
            pickerWheel.Spin ();
        });
    }

    private void Update() {
        if(GlobalCash.CashCount >= SpinPrice)
        {
            uiSpinButton.interactable=true;
            UiSpinButtonText.text = "Spin Price: $" + SpinPrice;
        }
        else
        {
            uiSpinButton.interactable=false;
            UiSpinButtonText.text = "Spin Price: $" + SpinPrice;
        }
    }

    IEnumerator SpinAgain(){
        yield return new WaitForSeconds(1);
            uiSpinButton.interactable = false;
            UiSpinButtonText.text = "Spinning";
            pickerWheel.OnSpinStart (() => {
                Debug.Log ("spin Started..");
            });
            pickerWheel.OnSpinEnd (WheelPiece => {
                Debug.Log ("Spin End: " + WheelPiece.Label+ " Amount:" + WheelPiece.Amount);
                uiSpinButton.interactable = true;
                UiSpinButtonText.text = "Spin Price: $" + SpinPrice;
                number = WheelPiece.Amount;
                if(number == 1)
                {
                    reward *= 2;
                    GlobalBananas.BananaCount += reward;
                }
                else if(number == 2)
                {
                    reward *= 2; 
                    GlobalCash.CashCount += reward;
                }
                else if(number == 3)
                {
                    reward *= 2;
                    GlobalCash.CashCount -= reward;
                }
                else if(number == 4)
                {
                    reward *= 50;
                    GlobalCash.CashCount += reward;
                }
                else if(number == 5)
                {
                    reward *= 2;
                    GlobalCash.CashCount -= reward;
                }
                else if(number == 6)
                {
                    reward *= 5;
                    GlobalBananas.BananaCount += reward;
                }
                else if(number == 7)
                {
                    reward *= 5;
                    GlobalCash.CashCount += reward;
                }
                else if(number == 8)
                {
                   StartCoroutine(SpinAgain());
                }
            });
            pickerWheel.Spin ();
    }
}
