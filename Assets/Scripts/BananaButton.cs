using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaButton : MonoBehaviour
{
    public GameObject bananaButton;
    public AudioSource Banana;
    public AudioSource Banana1;
    public AudioSource Banana2;
    public AudioSource Banana3;
    public int generateTone;
    
    public void ClickTheButton()
    {
        generateTone = Random.Range(1,5);
        if(generateTone == 1)
        {
            Banana.Play();
        }
        else if(generateTone == 2)
        {
            Banana1.Play();
        }
        else if(generateTone == 3)
        {
            Banana2.Play();
        }
        else
        {
            Banana3.Play();
        }

        GlobalBananas.BananaCount += 1;
    }
}
