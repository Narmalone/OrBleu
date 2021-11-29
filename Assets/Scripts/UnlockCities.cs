using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCities : MonoBehaviour
{
    public bool CityLocked;

    public GameObject UnlockCityButton;

    public GameObject ButtonCityDisabledStart;

    public void Start()
    {
        UnlockCityButton.SetActive(true);
        CityLocked = true;
        ButtonCityDisabledStart.SetActive(false);
    }

    public void UnlockCity()
    {
        if (FindObjectOfType<Gold>().myGold >= 150)
        {
            FindObjectOfType<Gold>().myGold -= 150;
            FindObjectOfType<Gold>().UpdateGold();
            CityLocked = false;
            UnlockCityButton.SetActive(false);
            ButtonCityDisabledStart.SetActive(true);
        }
        else
        {
            print("Vous ne pouvez pas débloquer la ville");
        }


    }
}
