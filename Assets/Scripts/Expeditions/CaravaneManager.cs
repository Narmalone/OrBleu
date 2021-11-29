using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CaravaneManager : MonoBehaviour
{
    public List<GameObject> SafePoints;
    public List<GameObject> DangerPoints;

    public GameObject Ville;
    public Expeditions myExpedition;
    public GameObject prefab;

    GameManager gamemanager;

    private void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
    }
    public void CaravaneSpawn()
    {

        if (gamemanager.CaravannePosseded > 0)
        {
            GameObject caravane = Instantiate(prefab, transform);
            caravane.GetComponent<Caravane>().points = SafePoints;
            gamemanager.CaravannePosseded--;
            caravane.GetComponent<Caravane>().myExpedition = myExpedition;
            caravane.GetComponent<Caravane>().CaraSafe = true;
        }   
    }

    public void CaravaneDangerSpawn()
    {

        if (gamemanager.CaravannePosseded > 0)
        {
            GameObject caravane = Instantiate(prefab, transform);
            caravane.GetComponent<Caravane>().points = DangerPoints;
            gamemanager.CaravannePosseded--;

            caravane.GetComponent<Caravane>().myExpedition = myExpedition;
            caravane.GetComponent<Caravane>().CaraDanger = true;
        }
    }


    private void Update()
    {
       
    }
    public IEnumerator StartSafeSpawnCaravane(float _s)
    {
        yield return new WaitForSeconds(_s);
        CaravaneSpawn();
    }


    public IEnumerator StartDangerSpawnCaravane(float _sD)
    {
        yield return new WaitForSeconds(_sD);
        CaravaneDangerSpawn();
    }

    internal void Launch(int _nb)
    {
        for (int i = 0; i < _nb ; i++)
        {
            StartCoroutine(StartSafeSpawnCaravane(i));
        }
    }

    internal void LaunchDangerCara(float _nbD)
    {
        for (int i = 0; i < _nbD; i++)
        {
            StartCoroutine(StartDangerSpawnCaravane(i));
        }
    }
}
