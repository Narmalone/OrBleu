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

    public FirsttimeTutorial firsttimeTutorial;
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


        if (dialogue.DialogueCount == 3 && firsttimeTutorial.isFirstTime == true)
        {
            TutoGuide.SetActive(true);
            animCount = 1;
            anim.SetTrigger("Enter");

        }
        else if (dialogue.DialogueCount == 4 && firsttimeTutorial.isFirstTime == true)
        {
            TutoGuide.transform.DOMove(new Vector3(-204.71f, 96.56f, -271.06f),2f);
            animCount = 2;

        }
        else if (dialogue.DialogueCount == 5 && firsttimeTutorial.isFirstTime == true)
        {
            animCount = 3;

            TutoGuide.transform.DOMove(new Vector3(-204.85f, 96.56f, -270.953f),2f);
        }
        else if(dialogue.DialogueCount == 9 && firsttimeTutorial.isFirstTime == true)
        {
            animCount = 4;
            TutoGuide.transform.DOMove(new Vector3(-205.137f, 96.56f, -270.645f), 2f);
        }
        else if(dialogue.DialogueCount == 11 && firsttimeTutorial.isFirstTime == true)
        {
            TutoGuide.SetActive(false);

        }
    }

}
