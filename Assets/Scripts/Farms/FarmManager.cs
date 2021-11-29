using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FarmManager : MonoBehaviour
{


    public void Start()
    {
        UpdateFarmLevel();
    }


    public void UpdateFarmLevel()
    {
        GetComponent<TextMeshProUGUI>().text = FindObjectOfType<Farm>().CurrentFarmLevel.ToString();
    }


}
