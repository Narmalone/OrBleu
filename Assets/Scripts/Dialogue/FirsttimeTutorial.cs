using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirsttimeTutorial : MonoBehaviour
{

    public bool isFirstTime;
    public Dialogue dialogue;

    public GameObject inTutorialCityA;
    public GameObject inTutorialCityF;
    public GameObject inTutorialCityC;


    public GameObject inTutorialFarm2;
    public GameObject inTutorialFarm3;
    // Start is called before the first frame update
    void Start()
    {
        

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

            print("les boutons doivent �tre d�sactiv�s");

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

}
