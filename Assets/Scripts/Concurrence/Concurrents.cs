using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Concurrents : MonoBehaviour
{
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

    public void Update()
    {
        ConcurrentDeafeated();
    }


    public void ConcurrentDeafeated()
    {
        if(goldManager.myGold >= 500 && Concurrent_1 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        }
        else if(goldManager.myGold >= 1000 && Concurrent_2 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        } 
        else if(goldManager.myGold >= 1300 && Concurrent_3 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        }
        else if(goldManager.myGold >= 1800 && Concurrent_4 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        }
        else if(goldManager.myGold >= 2200 && Concurrent_5 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        }
        else if(goldManager.myGold >= 3000 && Concurrent_6 == true)
        {
            
            GetComponent<Image>().color = Color.green;
        }
       
    }





}
