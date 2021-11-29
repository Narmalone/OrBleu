using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MontaubanExpe : MonoBehaviour
{
    Color ColorSelected = Color.white;
    Color ColorNotSelected = Color.gray;

    [SerializeField]
    private GameObject validateButton;

    public GameObject SafeCaravelPick1;
    public GameObject SafeCaravelPick2;
    public GameObject SafeCaravelPick3;

    public GameObject DangerCaravelPick1;
    public GameObject DangerCaravelPick2;
    public GameObject DangerCaravelPick3;

    public CaravaneManager CaravaneMNG;

    GameManager gamemanager;

    private void Start()
    {

        gamemanager = FindObjectOfType<GameManager>();

        SafeCaravelPick1.GetComponent<Image>().color = ColorNotSelected;
        SafeCaravelPick2.GetComponent<Image>().color = ColorNotSelected;
        SafeCaravelPick3.GetComponent<Image>().color = ColorNotSelected;

        DangerCaravelPick1.GetComponent<Image>().color = ColorNotSelected;
        DangerCaravelPick2.GetComponent<Image>().color = ColorNotSelected;
        DangerCaravelPick3.GetComponent<Image>().color = ColorNotSelected;


    }


    private void Update()
    {
        
    }

    //Sélectionner/déselectionner l'expedition Risquée, les caravanes

    public void UnselectDangerButtonExpedition()
    {
        Debug.Log("Déselect expe");

          

           SafeCaravelPick1.GetComponent<Image>().color = ColorNotSelected;
           SafeCaravelPick2.GetComponent<Image>().color = ColorNotSelected;
           SafeCaravelPick3.GetComponent<Image>().color = ColorNotSelected;


    }

    //Sélectionner/déselectionner l'expedition safe, lmes caravanes
    public void UnselectSafeButtonExpedition()
    {
        Debug.Log("Déselect expe");


           DangerCaravelPick1.GetComponent<Image>().color = ColorNotSelected;
           DangerCaravelPick2.GetComponent<Image>().color = ColorNotSelected;
           DangerCaravelPick3.GetComponent<Image>().color = ColorNotSelected;


    }

    //activer ou non les boutons en fonctions du nombre de pastel du joueur
    public void checkPastel()
    {
        Debug.Log("dans le check pastel");

        


        if (FindObjectOfType<Pastel>().myPastel < 10 || gamemanager.CaravannePosseded < 1)
        {
            SafeCaravelPick1.GetComponent<Button>().interactable = false;
            SafeCaravelPick2.GetComponent<Button>().interactable = false;
            SafeCaravelPick3.GetComponent<Button>().interactable = false;

            DangerCaravelPick1.GetComponent<Button>().interactable = false;
            DangerCaravelPick2.GetComponent<Button>().interactable = false;
            DangerCaravelPick3.GetComponent<Button>().interactable = false;


        }
        else if (FindObjectOfType<Pastel>().myPastel >= 10 && gamemanager.CaravannePosseded == 1 || FindObjectOfType<Pastel>().myPastel < 15)
        {
            SafeCaravelPick1.GetComponent<Button>().interactable = true;
            SafeCaravelPick2.GetComponent<Button>().interactable = false;
            SafeCaravelPick3.GetComponent<Button>().interactable = false;

            DangerCaravelPick1.GetComponent<Button>().interactable = true;
            DangerCaravelPick2.GetComponent<Button>().interactable = false;
            DangerCaravelPick3.GetComponent<Button>().interactable = false;

            if (gamemanager.CaravannePosseded < 1)
            {
                SafeCaravelPick1.GetComponent<Button>().interactable = false;

            }



        }
        else if (FindObjectOfType<Pastel>().myPastel >= 15 && gamemanager.CaravannePosseded > 1 && gamemanager.CaravannePosseded < 3)
        {
            SafeCaravelPick1.GetComponent<Button>().interactable = true;
            SafeCaravelPick2.GetComponent<Button>().interactable = true;
            SafeCaravelPick3.GetComponent<Button>().interactable = false;

            DangerCaravelPick1.GetComponent<Button>().interactable = true;
            DangerCaravelPick2.GetComponent<Button>().interactable = true;
            DangerCaravelPick3.GetComponent<Button>().interactable = false;


        }
      
        else if (FindObjectOfType<Pastel>().myPastel >= 15 && gamemanager.CaravannePosseded >= 2 && FindObjectOfType<Pastel>().myPastel < 20)
        {
            SafeCaravelPick2.GetComponent<Button>().interactable = true;
            SafeCaravelPick3.GetComponent<Button>().interactable = false;

            DangerCaravelPick2.GetComponent<Button>().interactable = true;
            DangerCaravelPick3.GetComponent<Button>().interactable = false;


        }

        else if (FindObjectOfType<Pastel>().myPastel >= 15 && gamemanager.CaravannePosseded <2)
        {
            SafeCaravelPick1.GetComponent<Button>().interactable = true;
            SafeCaravelPick2.GetComponent<Button>().interactable = false;
            SafeCaravelPick3.GetComponent<Button>().interactable = false;

            DangerCaravelPick1.GetComponent<Button>().interactable = true;
            DangerCaravelPick2.GetComponent<Button>().interactable = false;
            DangerCaravelPick3.GetComponent<Button>().interactable = false;

            if (gamemanager.CaravannePosseded == 0)
            {
                DangerCaravelPick1.GetComponent<Button>().interactable = false;

                SafeCaravelPick1.GetComponent<Button>().interactable = false;
            }

        } 



        else if (FindObjectOfType<Pastel>().myPastel >= 20 && gamemanager.CaravannePosseded >= 3)
        {
            SafeCaravelPick1.GetComponent<Button>().interactable = true;
            SafeCaravelPick2.GetComponent<Button>().interactable = true;
            SafeCaravelPick3.GetComponent<Button>().interactable = true;

            DangerCaravelPick1.GetComponent<Button>().interactable = true;
            DangerCaravelPick2.GetComponent<Button>().interactable = true;
            DangerCaravelPick3.GetComponent<Button>().interactable = true;

            
        }
        



    }
    //Selection des caravanes
    public void Select1SafeCaravel()
    {

        
        SafeCaravelPick1.GetComponent<Image>().color = ColorSelected;
         SafeCaravelPick2.GetComponent<Image>().color = ColorNotSelected;
         SafeCaravelPick3.GetComponent<Image>().color = ColorNotSelected;


    }
    public void Select2Safecaravel()
    {
       
        SafeCaravelPick1.GetComponent<Image>().color = ColorNotSelected;
        SafeCaravelPick2.GetComponent<Image>().color = ColorSelected;
        SafeCaravelPick3.GetComponent<Image>().color = ColorNotSelected;
        
    }
    
    public void Select3Safecaravel()
    {
        
        SafeCaravelPick1.GetComponent<Image>().color = ColorNotSelected;
        SafeCaravelPick2.GetComponent<Image>().color = ColorNotSelected;
        SafeCaravelPick3.GetComponent<Image>().color = ColorSelected;
        
    }
    public void Select1DangerCaravel()
    {
    
         DangerCaravelPick1.GetComponent<Image>().color = ColorSelected;
         DangerCaravelPick2.GetComponent<Image>().color = ColorNotSelected;
         DangerCaravelPick3.GetComponent<Image>().color = ColorNotSelected;


    }
    public void Select2Danger2caravel()
    {
       
        DangerCaravelPick1.GetComponent<Image>().color = ColorNotSelected;
        DangerCaravelPick2.GetComponent<Image>().color = ColorSelected;
        DangerCaravelPick3.GetComponent<Image>().color = ColorNotSelected;
        
    }
    
    public void Select3Danger3caravel()
    {
        
        DangerCaravelPick1.GetComponent<Image>().color = ColorNotSelected;
        DangerCaravelPick2.GetComponent<Image>().color = ColorNotSelected;
        DangerCaravelPick3.GetComponent<Image>().color = ColorSelected;
     
    }

    //verifier si on peut valider
    public void checkValidate()
    {
        if(FindObjectOfType<Pastel>().myPastel <10 && gamemanager.CaravannePosseded > 0)
        {
            validateButton.GetComponent<Button>().interactable = false;
        }
        else if(gamemanager.CaravannePosseded == 0)
        {
            validateButton.GetComponent<Button>().interactable = false;
        }
        else if(FindObjectOfType<Pastel>().myPastel >=10 && gamemanager.CaravannePosseded > 0)
        {
            validateButton.GetComponent<Button>().interactable = true;
        }
    }

}
