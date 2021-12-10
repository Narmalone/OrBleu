using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class FarmLocked : MonoBehaviour
{
    public bool farmLocked;

    public FirsttimeTutorial firstTimeTutorial;

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
        if(Goldmanager.myGold >= 150 && firstTimeTutorial.isFirstTime == false)
        {
            Goldmanager.myGold -= 150;
            Goldmanager.goldUpdate();
            gold.UpdateGold();
            farmLocked = false;
            ButtonDisabledStart.SetActive(true);

            //DOMove car le SetActive ne marchait pas
            UnlockButton.transform.DOMoveX(2000f, 2f);
            //print(UnlockButton);
        }
        else
        {
            print("Vous ne pouvez pas débloquer la ferme");
        }
        

   }



}
