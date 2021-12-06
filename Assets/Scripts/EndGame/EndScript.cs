using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{

    public TextMeshProUGUI DefeatTxt;
    
    //public TextMeshProUGUI VictoryTxt;

    public GameObject DefeatScreen;
    

    public GoldManager goldManager;
    public Gold gold;

    public GlobalTimer globalTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //10k gold pour le moment
        //Ne marche pas//
        if (globalTimer.timeValue <= 0 && goldManager.myGold < 10000)
        {
            goldManager.myGold = 500;
            gold.UpdateGold();

        }
    }
}
