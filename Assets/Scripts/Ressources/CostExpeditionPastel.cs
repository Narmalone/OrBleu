using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CostExpeditionPastel : MonoBehaviour
{

    public Expeditions expedition;

    public int calculExpeditionPastel;

    public int costNbCara;

    // Start is called before the first frame update
    void Start()
    {
        costNbCara = 5;

    }

    // Update is called once per frame
    public void Update()
    {
        calculExpeditionPastel = expedition.CaravelNumberSelected * costNbCara;
        GetComponent<TextMeshProUGUI>().text = calculExpeditionPastel.ToString();

    }
}
