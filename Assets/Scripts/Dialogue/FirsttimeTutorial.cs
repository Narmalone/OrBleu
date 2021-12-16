using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FirsttimeTutorial : MonoBehaviour
{

    public bool isFirstTime;
    public bool wasInTuto;
    public Dialogue dialogue;

    public GameObject inTutorialCityA;
    public GameObject inTutorialCityF;
    public GameObject inTutorialCityC;


    public GameObject inTutorialFarm2;
    public GameObject inTutorialFarm3;

    public GameObject buttonFarmLevel;

    public GameObject goBuyDisabled;
    public GameObject UnlockFirstCity;


    public GameObject CantRiskRoad;
    public GameObject CantSelectNbCara;

    // Start is called before the first frame update
    void Start()
    {
        wasInTuto = true;

    }

    // Update is called once per frame
    void Update()
    {
       
        if (isFirstTime == true)
        {
            inTutorialCityA.SetActive(false);
            inTutorialCityF.SetActive(false);
            inTutorialCityC.SetActive(false);

            inTutorialFarm2.SetActive(false);
            inTutorialFarm3.SetActive(false);

            buttonFarmLevel.GetComponent<Button>().interactable = false;

            if(dialogue.DialogueCount != 5)
            {
                UnlockFirstCity.GetComponent<Button>().interactable = false;

            }
            else if (dialogue.DialogueCount == 5)
            {
                UnlockFirstCity.GetComponent<Button>().interactable = true;

            }
            
            if(dialogue.DialogueCount != 9)
            {
                goBuyDisabled.GetComponent<Button>().interactable = false;

            }
            else if (dialogue.DialogueCount == 9)
            {
                goBuyDisabled.GetComponent<Button>().interactable = true;

            }

            CantRiskRoad.GetComponent<Button>().interactable = false;
            CantSelectNbCara.GetComponent<Button>().interactable = false;


            print("les boutons doivent être désactivés");

        }
        else if (isFirstTime == false)
        {
            inTutorialCityA.SetActive(true);
            inTutorialCityF.SetActive(true);
            inTutorialCityC.SetActive(true);

            inTutorialFarm2.SetActive(true);
            inTutorialFarm3.SetActive(true);
            wasInTuto = false;

            buttonFarmLevel.GetComponent<Button>().interactable = true;

            goBuyDisabled.GetComponent<Button>().interactable = true;
            UnlockFirstCity.GetComponent<Button>().interactable = true;

            CantRiskRoad.GetComponent<Button>().interactable = true;

        }
    }
    public void FirstTime()
    {
        isFirstTime = true;
    }

    public void notFirstTime()
    {        
     
        isFirstTime = false;

    }

    public void endTutorial()
    {
        if(dialogue.DialogueCount > 16)
        {
            isFirstTime = false;
        }
    }

}
