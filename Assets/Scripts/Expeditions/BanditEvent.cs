using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditEvent : MonoBehaviour
{


    public int Aggression;
    public bool UnderAttack;

    public void Start()
    {
        UnderAttack = false;
    }
    public void _BanditAggressionS3()
    {
        Aggression = Random.Range(1, 100);
        print(Aggression);
        if (Aggression <= 10)
        {
            CaravelsAgressed();
        }
        else
        {
            print("Le joueur ne sera pas aggressé");
        }
    } 
    public void _BanditAggressionD1()
    {
        Aggression = Random.Range(1, 100);
        print(Aggression);
        if(Aggression <= 30)
        {
            CaravelsAgressed();
        }
        else
        {
            print("Le joueur ne sera pas aggressé");
        }
    }
    public void _BanditAggressionD2()
    {
        Aggression = Random.Range(1, 100);
        print(Aggression);
        if(Aggression <= 35)
        {
            CaravelsAgressed();
        }
        else
        {
            print("Le joueur ne sera pas aggressé");
        }
    }
    public void _BanditAggressionD3()
    {
        Aggression = Random.Range(1, 100);
        print(Aggression);
        if(Aggression <= 40)
        {
            CaravelsAgressed();
        }
        else
        {
            print("Le joueur ne sera pas aggressé");
        }
    }

    public void CaravelsAgressed()
    {
        UnderAttack = true;
        print("Vous allez être aggréssé !!!");
    }
}
