using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caravane : MonoBehaviour
{
    //variables prochain poin et retour cara
    public int myIndexNextPos;
    public bool isComingBack;

    //speed
    float speed = 0.09f;

    //list point
    public List<GameObject> points;

    public Expeditions myExpedition;

    public bool CaraSafe;
    public bool CaraDanger;

    //Initialisation
    private void Start()
    {

        myIndexNextPos = 0;
        transform.position = points[0].transform.position;
        isComingBack = false;
        GetComponent<Animator>().SetTrigger("Enter");
    }

    private void Update()
    {
        //sécu quand y'a plus de points et déplacements
        if (myIndexNextPos < points.Count && myIndexNextPos>= 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[myIndexNextPos].transform.position, speed * Time.deltaTime);

        }
        var lookPos = points[myIndexNextPos].transform.position - transform.position;
        lookPos.y = 0;
        if (lookPos == Vector3.zero) { }
        else
        {
            var rotation = Quaternion.LookRotation(lookPos);
            rotation = rotation * Quaternion.Euler(0,90,0); 
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 5);
        }

    }


}
