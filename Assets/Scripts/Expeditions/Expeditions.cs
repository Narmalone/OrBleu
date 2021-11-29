using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Expeditions : MonoBehaviour
{

    public List<GameObject> SafeNumberCaravelSelected;
    public List<GameObject> DangerNumberCaravelSelected;
    private bool isDangerSelected = false;
    private bool isSafeSelected = true;


    private bool isCaravelNumberSelected = true;
    private bool isCaravelNumberNotSelected = false;

    public int CaravelNumberSelected = 0;

    public int CheckDangerousCount;
    public int CheckSafeCount;
    [SerializeField]
    private GameObject safeButton;
    [SerializeField]
    private GameObject dangerButton;

    public int UnselectSafeExpedition;
    public int UnselectDangerExpedition;


    public bool gotSafeSelected;


    Color ColorSelected = Color.white;
    Color ColorNotSelected = Color.gray;

    public int Aggression;

    public bool CurrentSafeUse;
    public bool CurrentDangerUse;

    public CaravaneManager CaravaneMNG;

    GameManager gamemanager;

    private void Start()
    {

        gamemanager = FindObjectOfType<GameManager>();

        isSafeSelected = true;
        isDangerSelected = false;

        UnselectDangerExpedition = 0;
        UnselectSafeExpedition = 0;

        CheckSafeCount = 0;
        CheckDangerousCount = 0;

        dangerButton.GetComponent<Image>().color = ColorNotSelected;
        safeButton.GetComponent<Image>().color = ColorNotSelected;

        gotSafeSelected = false;

        CurrentSafeUse = false;
        CurrentDangerUse = false;
    }

    //quand on prend l'expe dangereuse
    public void SelectDangerousExpedition()
    {
        isSafeSelected = false;
        isDangerSelected = true;


        UnselectDangerExpedition++;
        //Debug.Log(UnselectDangerExpedition);

    }

    //quand on prend l'expe safe
    public void SelectSafeExpedition()
    {
        isSafeSelected = true;
        isDangerSelected = false;

        UnselectSafeExpedition++;


        //Debug.Log("Select Safe Expeditions");

    }
    //lorsque l'on sélectionne l'expe dangereuse
    public void UnselectTheDangerExpedition()
    {
      
        if (UnselectDangerExpedition == 1)
        {
            dangerButton.GetComponent<Image>().color = ColorSelected;
            UnselectSafeExpedition = 2;
            safeButton.GetComponent<Image>().color = ColorNotSelected;
            UnselectSafeExpedition = 0;
            //Debug.Log("Déselectionner la risquée");
        }

        else if (UnselectDangerExpedition == 2 || UnselectDangerExpedition == 0)
        {
            dangerButton.GetComponent<Image>().color = ColorNotSelected;
            UnselectDangerExpedition = 0;
        }
        
    }
 
    //lorsque l'on s'electionne l'expe safe
    public void UnselectTheSafeExpedition()
    {
      
        if (UnselectSafeExpedition == 1)
        {
            safeButton.GetComponent<Image>().color = ColorSelected;
            UnselectDangerExpedition = 2;
            if(UnselectDangerExpedition == 2)
            {
                dangerButton.GetComponent<Image>().color = ColorNotSelected;
                UnselectDangerExpedition = 0;
            }
        }

        else if (UnselectSafeExpedition == 2 || UnselectSafeExpedition == 0)
        {

            safeButton.GetComponent<Image>().color = ColorNotSelected;
            UnselectSafeExpedition = 0;
        }
        
    }
    //Nb de caravanes sélectionnées
    public void NumberSafeCaravelSelected(int _nbCaravel)
    {
        isCaravelNumberSelected = true;
        isCaravelNumberNotSelected = false;
        CaravelNumberSelected = _nbCaravel;


    }
    
    //Valider la route et cout du pastel
    public void ValidateRoad()
    {

        UnselectDangerExpedition = 0;
        UnselectSafeExpedition = 0;

        //Si la voie dangereuse est sélectionnée//
        if(isDangerSelected == true)
        {
            if (CurrentDangerUse == true)
            {
                print("Route danger use");
            }
            else
            {
                if (gamemanager.CaravannePosseded >= CaravelNumberSelected)
                {
                    //UPDATE LE PASTEL ET LANCER LA COROUTINE DANS LE CARA MANAGER
                    CaravaneMNG.LaunchDangerCara(CaravelNumberSelected);
                    FindObjectOfType<Pastel>().myPastel -= CaravelNumberSelected * 5;
                    FindObjectOfType<Pastel>().UpdatePastel();
                    CurrentDangerUse = true;

                    switch (CaravelNumberSelected)
                    {

                        case 1:
                            FindObjectOfType<BanditEvent>()._BanditAggressionD1();
                            break;
                        case 2:
                            FindObjectOfType<BanditEvent>()._BanditAggressionD1();
                            break;
                        case 3:
                            FindObjectOfType<BanditEvent>()._BanditAggressionD3();
                            break;

                    }

                }

                // appel bandit event en fonction du nb de caravane sélectionné
               
            }
        }

        //si la route safe est sélectionnée

        else if (isSafeSelected == true)
        {

            if (CurrentSafeUse == true)
            {
                print("Route safe use");
            }
            else
            {
                if (isSafeSelected == true && gamemanager.CaravannePosseded >= CaravelNumberSelected)
                {

                    //UPDATE LE PASTEL ET LANCER LA COROUTINE DANS LE CARA MANAGER

                    CaravaneMNG.Launch(CaravelNumberSelected);
                    FindObjectOfType<Pastel>().myPastel -= CaravelNumberSelected * 5;
                    FindObjectOfType<Pastel>().UpdatePastel();
                    CurrentSafeUse = true;

                    //Appel bandit event quand il y'a 3 cara sécurisé sélectionnée

                    switch (CaravelNumberSelected)
                    {
                        case 3:
                            FindObjectOfType<BanditEvent>()._BanditAggressionS3();
                            break;
                    }



                }
            }
        }
    }
}
