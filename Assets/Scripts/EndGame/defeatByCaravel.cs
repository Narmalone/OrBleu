using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defeatByCaravel : MonoBehaviour
{
    public float currentTime;
    public float StartingTime;

    public GoldManager goldManager;

    public GameManager gameManager;
    public GameObject defeatByCaravelScreen;

    public CaravanePossessedManager CPM;


    private void Update()
    {
        if(CPM.myCaravanes == 0 && goldManager.myGold < 250)
        {
            defeatByCaravelScreen.SetActive(true);
        }
    }


}
