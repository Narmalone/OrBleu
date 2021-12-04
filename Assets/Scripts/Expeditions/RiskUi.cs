using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiskUi : MonoBehaviour
{
    public GameObject SafeRisk1;
    public GameObject SafeRisk2;
    public GameObject SafeRisk3;

    public GameObject DangerRisk1;
    public GameObject DangerRisk2;
    public GameObject DangerRisk3;

    public Expeditions expedition;

    // Start is called before the first frame update
    void Start()
    {
        SafeRisk1.SetActive(false);
        SafeRisk2.SetActive(false);
        SafeRisk3.SetActive(false);

        DangerRisk1.SetActive(false);
        DangerRisk2.SetActive(false);
        DangerRisk3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (expedition.CaravelNumberSelected == 1 && expedition.isSafeSelected == true) 
        {
            SafeRisk1.SetActive(true);
            print("safe risk activé");
        }
        else
        {
            SafeRisk1.SetActive(false);
        }

        if(expedition.CaravelNumberSelected == 2 && expedition.isSafeSelected == true)
        {
            SafeRisk2.SetActive(true);
        }
        else
        {
            SafeRisk2.SetActive(false);
        }
        if (expedition.CaravelNumberSelected == 3 && expedition.isSafeSelected == true)
        {
            SafeRisk3.SetActive(true);
        }
        else
        {
            SafeRisk3.SetActive(false);
        }

        if(expedition.CaravelNumberSelected == 1 && expedition.isDangerSelected == true) 
        {
            DangerRisk1.SetActive(true);
        }
        else
        {
            DangerRisk1.SetActive(false);
        } 
        if(expedition.CaravelNumberSelected == 2 && expedition.isDangerSelected == true) 
        {
            DangerRisk2.SetActive(true);
        }
        else
        {
            DangerRisk2.SetActive(false);
        } 
        
        if(expedition.CaravelNumberSelected == 3 && expedition.isDangerSelected == true) 
        {
            DangerRisk3.SetActive(true);
        }
        else
        {
            DangerRisk3.SetActive(false);
        }



    }
}
