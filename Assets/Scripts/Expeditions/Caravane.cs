using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caravane : MonoBehaviour
{
    //variables prochain poin et retour cara
    public int myIndexNextPos;
    public bool isComingBack;

    //speed
    float speed = 10;

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

    }

    private void Update()
    {
        //sécu quand y'a plus de points et déplacements
        if (myIndexNextPos < points.Count && myIndexNextPos>= 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[myIndexNextPos].transform.position, speed * Time.deltaTime);

        }

    }


}
