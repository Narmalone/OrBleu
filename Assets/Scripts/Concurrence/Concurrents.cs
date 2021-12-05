using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Concurrents : MonoBehaviour
{

    //CONCURRENT ON AURAIT PU LIST AUSSI
    public bool Concurrent_1;
    public bool Concurrent_2;
    public bool Concurrent_3;
    public bool Concurrent_4;
    public bool Concurrent_5;
    public bool Concurrent_6;

    public GoldManager goldManager;

    public void Start()
    {
        
    }

    //VERIFIER SI LE JOUEUR A BATTU UN CONCURRENT
    public void Update()
    {
        ConcurrentDeafeated();
    }

    //CONCURRENT BATTU/EN COURS//
    public void ConcurrentDeafeated()
    {
        //conc 1
        if(goldManager.myGold >= 500 && Concurrent_1 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        }
        else if(goldManager.myGold < 500 && Concurrent_1 == true)
        {
            
            GetComponent<Image>().color = Color.red;
        }
        //conc 2
        else if(goldManager.myGold >= 1000 && Concurrent_2 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        } 
        
        else if(goldManager.myGold < 1000 && Concurrent_2 == true)
        {
            
            GetComponent<Image>().color = Color.red;
        } 
        //conc 3
        else if(goldManager.myGold >= 2000 && Concurrent_3 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        } 
        else if(goldManager.myGold < 2000 && Concurrent_3 == true)
        {
            
            GetComponent<Image>().color = Color.red;
        }

        //conc 4

        else if (goldManager.myGold >= 5000 && Concurrent_4 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        } 
        else if (goldManager.myGold < 5000 && Concurrent_4 == true)
        {
            
            GetComponent<Image>().color = Color.red;
        }
        //conc 5

        else if(goldManager.myGold >= 8000 && Concurrent_5 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        } 
        else if(goldManager.myGold < 8000 && Concurrent_5 == true)
        {
            
            GetComponent<Image>().color = Color.red;
        }
        //conc 6
        else if(goldManager.myGold >= 10000 && Concurrent_6 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        } 
        
        else if(goldManager.myGold < 10000 && Concurrent_6 == true)
        {
            
            GetComponent<Image>().color = Color.red;
        }
       
    }





}
