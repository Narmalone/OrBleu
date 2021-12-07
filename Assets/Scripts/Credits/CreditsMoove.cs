using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CreditsMoove : MonoBehaviour
{


    public GameObject Background;

    [SerializeField]
    TextMeshProUGUI Credits;


    public float SpeedToDown = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Background.transform.position = transform.position + new Vector3(0f, 0.5f, 0f);
        Credits.transform.position = transform.position + new Vector3(0f, 0.5f, 0f);
    }
}
