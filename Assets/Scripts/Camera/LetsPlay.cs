using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LetsPlay : MonoBehaviour
{

    public GlobalTimer GT;
    public void StartPlay()
    {
        
        transform.DOMove(new Vector3(-205.52f, 97.77f, -270.82f), 5f);
        transform.DORotate(new Vector3(79.576f, 429.422f, 348.934f), 5f);


    }
}
