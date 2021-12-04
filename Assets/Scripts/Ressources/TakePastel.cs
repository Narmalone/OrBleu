using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class TakePastel : MonoBehaviour
{

    public PastelManager Pastelmanager;

   

    // Update is called once per frame
    public void Update()
    {
        GetComponent<TextMeshProUGUI>().text = Pastelmanager.myPastel.ToString();

    }
}
