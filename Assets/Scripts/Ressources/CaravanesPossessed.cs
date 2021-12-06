using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CaravanesPossessed : MonoBehaviour
{
    public GameManager gameManager;

    public void Start()
    {
        GetComponent<TextMeshProUGUI>().text = gameManager.CaravannePosseded.ToString();
    }

    private void Update()
    {
        GetComponent<TextMeshProUGUI>().text = gameManager.CaravannePosseded.ToString();
    }
    public void MoreCaravel()
    {
        GetComponent<TextMeshProUGUI>().text = gameManager.CaravannePosseded.ToString();
        Debug.Log("AjoutCaravel");
    }
    
}
