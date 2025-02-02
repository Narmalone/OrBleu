using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalTimer : MonoBehaviour
{
    public float timeValue;
    public TextMeshProUGUI timerText;

    public GameObject defeatScreen;

    public GameObject VictoryScreen;

    public GameObject globalTimer;
    public bool isActivated;

    public PastelManager pastelManager;

    public CaravanePossessedManager CPM;

    public GameManager GM;

    //public GameObject runningOutOfTime;

    public GoldManager goldManager;

    public Dialogue dialogue;

    public bool waitingForCamMoove;

    private void Start()
    {
        //360 = 5 min
        timeValue = 360;
        isActivated = false;
    }
    private void Update()
    {

        if(dialogue.DialogueCount > 16)
        {
            isActivated = true;
            //print("Activated true");
        }

       

        if (timeValue > 0 && isActivated == true)
        {


            timeValue -= Time.deltaTime;
            
           
            //print(timeValue);
        }
        else if (timeValue <= 0 && isActivated == true && goldManager.myGold < 5000)
        {
            timeValue = 0;
            defeatScreen.SetActive(true);
        }
        else if (timeValue <= 0 && isActivated == true && goldManager.myGold >= 5000)
        {
            timeValue = 0;
            VictoryScreen.SetActive(true);
        }


        if(timeValue < 60 && isActivated == true)
        {
            timerText.color = Color.red;
            FindObjectOfType<audioManager>().Play("chrono");
        }

        DisplayTime(timeValue);
     

    }

    //
    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public void noTutorial()
    {
        timeValue = 365;
        GM.CaravannePosseded = 2;
        CPM.myCaravanes = 2;
        waitingForCamMoove = true;
        isActivated = true;
    }
}
