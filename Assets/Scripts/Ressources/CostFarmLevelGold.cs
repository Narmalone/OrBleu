using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CostFarmLevelGold : MonoBehaviour
{

    public Farm farm;

    public GoldManager Goldmanager;

    public GameObject DisableUpgrade;

    public int costLevelFarm;

    public int calculFarmGold;

    public void Start()
    {
        costLevelFarm = 25;
    }

    public void Update()
    {
        if(Goldmanager.myGold < calculFarmGold)
        {
            DisableUpgrade.GetComponent<Button>().interactable = false;
        }
        else if (Goldmanager.myGold >= calculFarmGold)
        {
            DisableUpgrade.GetComponent<Button>().interactable = true;
        }

        calculFarmGold = farm.CurrentFarmLevel * costLevelFarm;
        GetComponent<TextMeshProUGUI>().text = calculFarmGold.ToString();
    }
}
