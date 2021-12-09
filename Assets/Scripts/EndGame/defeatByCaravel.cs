using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defeatByCaravel : MonoBehaviour
{
    public float currentTime;
    public float StartingTime;

    public GameManager gameManager;
    public GameObject defeatByCaravelScreen;

    private void Start()
    {
        currentTime = StartingTime;
        StartingTime = 30f;
    }

    public void Update()
    {
        if(gameManager.CaravannePosseded == 0)
        {
            StartingTime -= 1f * Time.deltaTime;
            if(StartingTime <= 0)
            {
                StartingTime = 0f;
                defeatByCaravelScreen.SetActive(true);
                print(StartingTime);
            }
            
        }
        else if (gameManager.CaravannePosseded > 0)
        {
            resetStartingTime();
        }
    }


    void resetStartingTime()
    {
        StartingTime = 30f;
    }


}
