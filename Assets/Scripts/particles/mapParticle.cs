using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapParticle : MonoBehaviour
{


    public ParticleSystem partSys;


    private void Start()
    {
        partSys.Play();
    }

    public void OnPlay()
    {
        var particleMainSettings = partSys.main;
        partSys.Stop();


    }
}
