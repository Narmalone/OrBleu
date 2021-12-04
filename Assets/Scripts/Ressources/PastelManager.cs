using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PastelManager : MonoBehaviour
{

    public int myPastel;

    // Start is called before the first frame update
    public void Start()
    {
        myPastel = 10;
    }

    // Update is called once per frame
    public void PastelUpdate()
    {
        if (myPastel <= 0)
        {
            myPastel = 0;
        }
    }
}
