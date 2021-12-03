using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CostPastel : MonoBehaviour
{
    public int PastelWillCost;

    

    public void Start()
    {

    }

    public void UpdateCostPastel()
    {
        if(FindObjectOfType<Expeditions>().CaravelNumberSelected == 1)
        {
            PastelWillCost = -10;
            print(PastelWillCost);
        }
        else if (FindObjectOfType<Expeditions>().CaravelNumberSelected == 2)
        {
            PastelWillCost = -15;
            print(PastelWillCost);
        }

    }



}
