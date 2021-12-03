using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CostFarmLevelGold : MonoBehaviour
{

    public Farm farm;

    public int costLevelFarm;

    public int calculFarmGold;

    private void Start()
    {
        costLevelFarm = 25;
    }

    public void Update()
    {
        calculFarmGold = farm.CurrentFarmLevel * costLevelFarm;
        GetComponent<TextMeshProUGUI>().text = calculFarmGold.ToString();
    }
}
