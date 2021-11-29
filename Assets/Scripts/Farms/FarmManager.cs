using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FarmManager : MonoBehaviour
{

    //initialiser le start
    public void Start()
    {
        UpdateFarmLevel();
    }

    //update le text à modifier !
    public void UpdateFarmLevel()
    {
        GetComponent<TextMeshProUGUI>().text = FindObjectOfType<Farm>().CurrentFarmLevel.ToString();
    }


}
