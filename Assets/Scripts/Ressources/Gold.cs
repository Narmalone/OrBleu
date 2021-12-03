using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{

    public GoldManager Goldmanager;

    public void Start()
    {
        
         GetComponent<TextMeshProUGUI>().text = Goldmanager.myGold.ToString();
        

    }
    public void UpdateGold()
    {
         GetComponent<TextMeshProUGUI>().text = Goldmanager.myGold.ToString();
    }

}