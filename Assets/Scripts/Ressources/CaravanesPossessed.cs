using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CaravanesPossessed : MonoBehaviour
{
    public int lescaravanes;

    public void Start()
    {
        lescaravanes = 1;
        GetComponent<TextMeshProUGUI>().text = lescaravanes.ToString();

    }

    public void MoreCaravel()
    {
        lescaravanes++;
        GetComponent<TextMeshProUGUI>().text = lescaravanes.ToString();
        Debug.Log("AjoutCaravel");
    }
    
}
