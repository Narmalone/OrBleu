using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pastel : MonoBehaviour
{

    public PastelManager Pastelmanager;

    public void Start()
    {
        GetComponent<TextMeshProUGUI>().text = Pastelmanager.myPastel.ToString();
    }

    //Lorsque l'on modifie la valeur du pastel, l'update
    public void UpdatePastel()
    {
        GetComponent<TextMeshProUGUI>().text = Pastelmanager.myPastel.ToString();
    }




}