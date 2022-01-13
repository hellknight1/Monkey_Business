using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBanana : MonoBehaviour
{
    public static bool CreatingBananas;
    public static int BananaIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        BananaIncrease = GlobalBananaTree.NumberOfTrees;
        InternalIncrease = BananaIncrease;
        GlobalBananaTree.BananaPerSec = InternalIncrease;
        if(CreatingBananas == false)
        {
            CreatingBananas = true;
            StartCoroutine(CreateTheBanana());
        }   
    }

    IEnumerator CreateTheBanana()
    {
        GlobalBananas.BananaCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingBananas = false;
    }
}
