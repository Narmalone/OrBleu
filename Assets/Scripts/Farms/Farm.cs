using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class Farm : MonoBehaviour
{
    //variables pour timer
    public float currentTime = 0f;
    public float startingTime = 5f;

    //variables pour niveaux de la ferme
    public int CurrentFarmLevel;
    public int MaxFarmLevel;


    //gestion du button
    public GameObject ColorButton;
    public GameObject ButtonWhenLevelMax;

    public FarmManager farmManager;

    public GoldManager Goldmanager;
    public Gold gold;

    public PastelManager Pastelmanager;
    public Pastel pastel;

    Color color1;
       



    public void Start()
    {
        CurrentFarmLevel = 1;
        MaxFarmLevel = 6;
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
        else if (currentTime > 0)
        {

        }
        ColorUpdate();

        if(CurrentFarmLevel == MaxFarmLevel)
        {
            CurrentFarmLevel = MaxFarmLevel;
            ButtonWhenLevelMax.GetComponent<Button>().interactable = false;
        }

    }

    //changement de couleur en fonction de son état
    public void ColorUpdate()
    {
        if (currentTime == 0)
        {
            ColorButton.GetComponent<Image>().color = Color.green;

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
            FindObjectOfType<audioManager>().Play("faux");
            Pastelmanager.myPastel += 1 * CurrentFarmLevel;
            Pastelmanager.PastelUpdate();
            pastel.UpdatePastel();            
            Update();

        }
    }

    //ajout du niveau des fermes
    public void addFarmLevel()
    {

        //ajouter un niveau
        if (CurrentFarmLevel < MaxFarmLevel)
        {
            Goldmanager.myGold -= 25 * CurrentFarmLevel;
            Goldmanager.goldUpdate();
            gold.UpdateGold();            

            farmManager.UpdateFarmLevel(CurrentFarmLevel);

            CurrentFarmLevel++;

        }
   


    }

}
