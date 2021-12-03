using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalTimer : MonoBehaviour
{
    public float StartTimer;
    public float CurrentTimer;



    private void Start()
    {

        CurrentTimer = StartTimer;
    }

    private void Update()
    {
        CurrentTimer -= 1 * Time.deltaTime;

        if(CurrentTimer == 0)
        {
            CurrentTimer = 0;
            print("you loose");
        }

    }
}
