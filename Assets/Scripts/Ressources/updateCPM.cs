using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class updateCPM : MonoBehaviour
{

    public CaravanePossessedManager CPM;
   
    private void Update()
    {
        GetComponent<TextMeshProUGUI>().text = CPM.myCaravanes.ToString();
    }

    public void addCPM()
    {
        GetComponent<TextMeshProUGUI>().text = CPM.myCaravanes.ToString();
    }
}
