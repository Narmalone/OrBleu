using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int CaravannePosseded;

    public bool CaraInRoadSafeMontauban;
    public bool CaraInRoadDangerousMontauban;
    
    public bool CaraInRoadSafeRabastens;
    public bool CaraInRoadDangerousRabastens;

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
}
