using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaravanePossessedManager : MonoBehaviour
{

    public GameManager gameManager;

    public int myCaravanes;

    void Start()
    {
        myCaravanes = 1;
    }

    void Update()
    {
        
    }

    public void updateMyCaravane()
    {
        myCaravanes++;
    }
}
