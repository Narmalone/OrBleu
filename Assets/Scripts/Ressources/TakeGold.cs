using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TakeGold : MonoBehaviour
{
    public GoldManager Goldmanager;


    public void Update()
    {
        GetComponent<TextMeshProUGUI>().text = Goldmanager.myGold.ToString();
    }
}
