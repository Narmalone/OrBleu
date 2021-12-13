using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int CaravannePosseded;

    public FirsttimeTutorial firstTimeTurorial;

    void Start()
    {
        CaravannePosseded = 1;
    }

    private void Update()
    {
        if(CaravannePosseded <= 0)
        {
            CaravannePosseded = 0;
        }
    }

    public void onTutorial()
    {
        if (firstTimeTurorial.isFirstTime == true)
        {
            CaravannePosseded = 1;

        }
    }
}
