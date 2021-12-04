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
        UpdateFarmLevel(0);
    }



    //update le text à modifier !
    public void UpdateFarmLevel(int CurrentFarmLevel)
    {
        GetComponent<TextMeshProUGUI>().text = CurrentFarmLevel.ToString();
    }

    
}
