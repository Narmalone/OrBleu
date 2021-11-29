using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    public int myGold;


    private void Start()
    {
        myGold = 750;
        GetComponent<TextMeshProUGUI>().text = myGold.ToString();

    }
    public void UpdateGold()
    {
        GetComponent<TextMeshProUGUI>().text = myGold.ToString();
        if(myGold < 0)
        {
            myGold = 0;
        }
    }

}