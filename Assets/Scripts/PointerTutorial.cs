using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;


public class PointerTutorial : MonoBehaviour
{
    public GameObject TutoGuide;

    public Dialogue dialogue;

    public Animator anim;

    public int animCount;

    // Start is called before the first frame update
    void Start()
    {
        TutoGuide.SetActive(false);

        anim.GetComponent<Animator>();
        animCount = 1;
    }

    // Update is called once per frame
    public void Update()
    {


        if (dialogue.DialogueCount == 3)
        {
            TutoGuide.SetActive(true);
            animCount = 1;
            anim.SetTrigger("Enter");

            print("doit activer le curseur");
        }
        else if (dialogue.DialogueCount == 4)
        {
            TutoGuide.transform.DOMove(new Vector3(-204.71f, 96.56f, -271.06f),2f);
            animCount = 2;
            anim.SetTrigger("Exit");

        }
        else if (dialogue.DialogueCount == 5)
        {
            animCount = 3;
            TutoGuide.transform.DOMove(new Vector3(-204.805f, 96.56f, -270.952f),5f);
        }
    }

    void RecoltPastelPos()
    {
        
    }

}
