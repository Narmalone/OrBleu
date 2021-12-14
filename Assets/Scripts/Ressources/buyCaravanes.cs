using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyCaravanes : MonoBehaviour
{

    GameManager gamemanager;

    public GoldManager Goldmanager;

    public GameObject AcheterCaravanne;

    public CaravanePossessedManager CPM;

    public Gold gold;



    public void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
        AcheterCaravanne.GetComponent<Button>().interactable = true;
    }

    public void Update()
    {
        if(Goldmanager.myGold >= 250)
        {
            AcheterCaravanne.GetComponent<Button>().interactable = true;

        }
        else if(Goldmanager.myGold < 250)
        {
            AcheterCaravanne.GetComponent<Button>().interactable = false;
        }
    }
    public void buyCaravane()
    {


        if (Goldmanager.myGold < 250)
        {
            AcheterCaravanne.GetComponent<Button>().interactable = false;
            Debug.Log("Vous ne possédez pas assez d'argent");
        }
        else if(Goldmanager.myGold >= 250)
        {
            gamemanager.CaravannePosseded++;
            AcheterCaravanne.GetComponent<Button>().interactable = true;
            FindObjectOfType<CaravanesPossessed>().MoreCaravel();
            Goldmanager.myGold -= 250;
            Goldmanager.goldUpdate();
            gold.UpdateGold();


            Debug.Log("Caravane achetée");

        }
    }
}
