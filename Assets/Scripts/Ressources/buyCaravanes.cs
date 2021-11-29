using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyCaravanes : MonoBehaviour
{

    GameManager gamemanager;


    private void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();

    }
    public void buyCaravane()
    {
        gamemanager.CaravannePosseded++;
      

        if (FindObjectOfType<Gold>().myGold < 250)
        {
            FindObjectOfType<Button>().interactable = false;
            //Debug.Log("Vous ne possédez pas assez d'argent");
        }
        else if(FindObjectOfType<Gold>().myGold >= 250)
        {
            FindObjectOfType<CaravanesPossessed>().MoreCaravel();
            FindObjectOfType<Gold>().myGold -= 250;
            FindObjectOfType<Gold>().UpdateGold();


            //Debug.Log("Caravane achetée");

        }
    }
}
