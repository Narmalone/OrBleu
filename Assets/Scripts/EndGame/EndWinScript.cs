using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndWinScript : MonoBehaviour
{


    public GoldManager goldManager;

    public GlobalTimer globalTimer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //5000 golds
        if (globalTimer.timeValue <= 0 && goldManager.myGold > 5000)
        {

            GetComponent<TextMeshProUGUI>().text = goldManager.myGold.ToString();
        }
    }
}
