using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GoldManager : MonoBehaviour
{
    public int myGold;


    private void Start()
    {
        myGold = 400;
    }


    public void goldUpdate()
    {
        if (myGold < 0)
        {
            myGold = 0;
        }
    }
}
