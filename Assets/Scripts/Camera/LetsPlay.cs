using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LetsPlay : MonoBehaviour
{
    public void StartPlay()
    {
        transform.DOMove(new Vector3(-206.127f, 97.187f, -271.471f), 5f);
    }
}
