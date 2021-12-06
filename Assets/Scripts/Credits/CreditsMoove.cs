using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMoove : MonoBehaviour
{


    public GameObject Background;
    public float SpeedToDown = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Background.transform.position = transform.position + new Vector3(0.3f * SpeedToDown, 0f, 0f);
    }
}
