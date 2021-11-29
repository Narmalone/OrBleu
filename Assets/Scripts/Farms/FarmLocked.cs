using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FarmLocked : MonoBehaviour
{
    public bool farmLocked;

    public GameObject UnlockButton;

    public GameObject ButtonDisabledStart;

    public void Start()
    {
        UnlockButton.SetActive(true);
        farmLocked = true;
        ButtonDisabledStart.SetActive(false);
    }

    public void UnlockFarm()
    {
        if(FindObjectOfType<Gold>().myGold >= 150)
        {
            FindObjectOfType<Gold>().myGold -= 150;
            FindObjectOfType<Gold>().UpdateGold();
            farmLocked = false;
            UnlockButton.SetActive(false);
            ButtonDisabledStart.SetActive(true);
        }
        else
        {
            print("Vous ne pouvez pas débloquer la ferme");
        }
        

    }



}
