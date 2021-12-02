using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LetsPlay : MonoBehaviour
{
    public void StartPlay()
    {
        transform.DOMove(new Vector3(-205.346f, 97.461f, -271.133f), 5f);
        transform.DORotate(new Vector3(79.576f, 429.422f, 348.934f), 5f);
    }
}
