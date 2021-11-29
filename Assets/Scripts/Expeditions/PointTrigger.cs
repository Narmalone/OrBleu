using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{

    public bool end;
    public bool start;
    public bool MidBanditEvent;

    //chercher le gameManager
    GameManager gamemanager;

    private void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();

    }
    private void OnTriggerEnter(Collider caravane)
    {

        //définir la caravane car
        Caravane car = caravane.GetComponent<Caravane>();

        //si collide avec un point qui a bool end
        if (end)
        {
            //faire revenir le car
            car.isComingBack = true;
           
        }
        else if (MidBanditEvent == true && FindObjectOfType<BanditEvent>().UnderAttack == true && car.CaraDanger)
        {
            FindObjectOfType<BanditEvent>().UnderAttack = false;
            car.myExpedition.CurrentDangerUse = false;
            Destroy(car.gameObject);

            print("car destroy");
        }
        else if (MidBanditEvent == true && FindObjectOfType<BanditEvent>().UnderAttack == true && car.CaraSafe)

        {
            FindObjectOfType<BanditEvent>().UnderAttack = false;

            car.myExpedition.CurrentSafeUse = false;
            Destroy(car.gameObject);

            print("car destroy");
        }
        
       

        if (car.isComingBack)
        {
            //faire bouger le car en fonction de sa pos pour revenir
            car.myIndexNextPos--;

        }
        else
        {
            //faire bouger le car en fonction de sa pos pour aller au dernier point de la liste

            car.myIndexNextPos++;

        }


        //si il revient  et qu'il est à nouveau sur start
        if(car.isComingBack && start)
        {
            FindObjectOfType<Gold>().myGold += 150;
            FindObjectOfType<Gold>().UpdateGold();
            //si car est en route de danger
            if (car.CaraDanger)
            {
                //Réinit la variable
                car.myExpedition.CurrentDangerUse = false;
                print("Current Danger use = false");



            }
            else if (car.CaraSafe)
            {
                //réinit la variable
                car.myExpedition.CurrentSafeUse = false;
                print("Current safe use = false");

            }
            else
            {
                Debug.LogError("Aucune zone");
            }
            //Rajouter 1 caravane disponible comme elle est revenue
            gamemanager.CaravannePosseded++;
            print(gamemanager.CaravannePosseded);

            //Détruire la caravane
            Destroy(car.gameObject);




            
        }


    }
}
