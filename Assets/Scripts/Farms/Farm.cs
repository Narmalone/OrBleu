using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class Farm : MonoBehaviour
{
    //variables pour timer
    float currentTime = 0f;
    float startingTime = 5f;

    //variables pour niveaux de la ferme
    public int CurrentFarmLevel;
    public int MaxFarmLevel;


    //gestion du button
    public GameObject ColorButton;
    public GameObject ButtonWhenLevelMax;

    public FarmManager farmManager;

    public bool ScaleColorButtonWhenTrue;

    Color color1;
       

    public void Start()
    {
        CurrentFarmLevel = 1;
        MaxFarmLevel = 5;
        currentTime = startingTime;


    }

    public void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        //si le temps arrive à 0 on peut récolter
        if (currentTime <= 0)
        {
            currentTime = 0;

        }
        ColorUpdate();

    }

    //changement de couleur en fonction de son état
    public void ColorUpdate()
    {
        if (currentTime == 0)
        {
            
            ColorButton.GetComponent<Image>().color = Color.green;

            if (ScaleColorButtonWhenTrue == true)
            {
                //ColorButton.GetComponent<Image>().transform.DOScale(5f, 2f * Time.deltaTime);
                ScaleColorButtonWhenTrue = false;

            }
            else if(ScaleColorButtonWhenTrue == false)
            {
                ColorButton.GetComponent<Image>().transform.DOScale(2f, 2f * Time.deltaTime);
                ScaleColorButtonWhenTrue = true;
            }
            // ColorButton.GetComponent<Image>().transform.DOShakePosition(0.5f, 0.5f);
        }
        else
        {
           
            ColorUtility.TryParseHtmlString("#FF2D00", out color1);
            ColorButton.GetComponent<Image>().color = color1;
        }
    }

    //récolter le pastel en fonction des prérequis si on appui sur le bouton
    public void CollectPastel()
    {
        if (currentTime == 0)
        {
            currentTime = startingTime;
            FindObjectOfType<Pastel>().myPastel += 2 * CurrentFarmLevel;
            FindObjectOfType<Pastel>().UpdatePastel();
            ColorButton.GetComponent<Image>().transform.DOScale(2f, 2f);
            
            Update();

        }
    }

    //ajout du niveau des fermes
    public void addFarmLevel()
    {

        //ajouter un niveau
        if (CurrentFarmLevel < 10 && FindObjectOfType<Gold>().myGold > CurrentFarmLevel * 25)
        {
            //TROUVER LE PROBLEME OU LORSQUE ON AMELIORER UNE FERME ET QUON VA A LAUTRE QUON LAMELIORE CA LA MET AU NIV DE LAUTRE
            CurrentFarmLevel++;
            FindObjectOfType<Gold>().myGold -= 25 * CurrentFarmLevel;
            FindObjectOfType<Gold>().UpdateGold();
            print("AddFarmLevel");
            //si le niveau == au lvl max on ne peut plus intéragir
            if (CurrentFarmLevel == MaxFarmLevel)
            {
                CurrentFarmLevel = MaxFarmLevel;
                ButtonWhenLevelMax.GetComponent<Button>().interactable = false;
            }

            farmManager.UpdateFarmLevel(CurrentFarmLevel);



        }
        else
        {
            print("vous n'avez pas les fonds nécéssaires");
        }


    }

}
