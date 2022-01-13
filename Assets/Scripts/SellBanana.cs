using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SellBanana : MonoBehaviour
{
    public GameObject bananaButton;
    public TextMeshProUGUI textbox;
    public AudioSource cashSound;
    public AudioSource cashSound1;
    public AudioSource cashSound2;
    public AudioSource cashSound3;
    public int generateTone;
    
    public void ClickTheButton()
    {
        if(GlobalBananas.BananaCount >= 1)
        {
            generateTone = Random.Range(1,5);
            if(generateTone == 1)
            {
                cashSound.Play();
            }
            else if(generateTone == 2)
            {
                cashSound1.Play();
            }
            else if(generateTone == 3)
            {
                cashSound2.Play();
            }
            else
            {
                cashSound3.Play();
            }
            GlobalBananas.BananaCount -= 1;
            GlobalCash.CashCount += 1;
        }
        else
        {
            textbox.text = "Not Enough Bananas To Sell";
            textbox.GetComponent<Animation>().Play("StatusAnim");
        }
        
    }
}
