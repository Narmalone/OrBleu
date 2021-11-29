using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pastel : MonoBehaviour
{
    public int myPastel;

    private void Start()
    {
        myPastel = 10;
        GetComponent<TextMeshProUGUI>().text = myPastel.ToString();

    }

    //Lorsque l'on modifie la valeur du pastel, l'update
    public void UpdatePastel()
    {

        if(myPastel <= 0)
        {
            myPastel = 0;
        }

        GetComponent<TextMeshProUGUI>().text = myPastel.ToString();
        Debug.Log("pastelUpdated");
    }


}