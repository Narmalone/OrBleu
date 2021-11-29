using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject MontaubanSafeRoad;
    public GameObject MontaubanDangerRoad;
    
    public GameObject RabastensSafeRoad;
    public GameObject RabastensDangerRoad;
    
    public GameObject CarcassonneSafeRoad;
    public GameObject CarcassonneDangerRoad;
    
    public GameObject FoixSafeRoad;
    public GameObject FoixDangerRoad;

    public bool CaraInRoadSafeMontauban;
    public bool CaraInRoadDangerousMontauban;


     public bool CaraInRoadSafeCarcassonne;
    public bool CaraInRoadDangerousCarcassonne;


    public bool CaraInRoadSafeFoix;
    public bool CaraInRoadDangerousFoix;

    public bool CaraInRoadSafeRabastens;
    public bool CaraInRoadDangerousRabastens;



    private void Start()
    {
        CaraInRoadSafeMontauban = false;
        CaraInRoadDangerousMontauban = false;

        CaraInRoadSafeRabastens = false;
        CaraInRoadDangerousRabastens = false;

        CaraInRoadSafeFoix = false; 
        CaraInRoadDangerousFoix = false;

        CaraInRoadSafeCarcassonne = false;
        CaraInRoadDangerousCarcassonne = false;

    }

    

}
