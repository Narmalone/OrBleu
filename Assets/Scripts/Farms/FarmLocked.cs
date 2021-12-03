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

    public Gold gold;
    public GoldManager Goldmanager;

    public void Start()
    {
        UnlockButton.SetActive(true);
        farmLocked = true;
        ButtonDisabledStart.SetActive(false);
    }

    public void UnlockFarm()
    {
        if(Goldmanager.myGold >= 150)
        {
            Goldmanager.myGold -= 150;
            Goldmanager.goldUpdate();
            gold.UpdateGold();
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
