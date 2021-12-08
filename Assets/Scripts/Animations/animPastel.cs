using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animPastel : MonoBehaviour
{

    Animator anim;

    
    [SerializeField]Farm ferme;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //appeler le triger pour entrer
        if(ferme.currentTime == 0)
        {
            anim.SetTrigger("Enter");
        }

        //sortie de l'anim et trigger exit
        else if(ferme.currentTime > 0)
        {
            anim.SetTrigger("Exit");
        }
    }
}
