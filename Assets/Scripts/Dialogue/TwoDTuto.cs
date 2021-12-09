using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TwoDTuto : MonoBehaviour
{

    public FirsttimeTutorial firsTimeTutorial;

    public GameObject ArrowTwoD;

    public GameObject ArrowBox;

    public GameObject PointerArrowTuto;

    public Dialogue dialogue;

    public Animator anim_TwoArrow;


    // Start is called before the first frame update
    void Start()
    {
        ArrowTwoD.SetActive(true);
        anim_TwoArrow.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogue.DialogueCount == 3)
        {
            ArrowTwoD.SetActive(false);
        }
        else if (dialogue.DialogueCount == 4)
        {
            ArrowTwoD.SetActive(true);
        }
        else if (dialogue.DialogueCount == 5)
        {
            ArrowTwoD.SetActive(false);
        }
        else if (dialogue.DialogueCount == 7)
        {
            PointerArrowTuto.SetActive(true);
            anim_TwoArrow.SetTrigger("Enter");
        }
        else if (dialogue.DialogueCount == 8)
        {

        }
    }


    public void tutoPastelCollect()
    {
        if(firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 3)
        {
            dialogue.GoNextDialog();
        }
        else if (firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 5)
        {
            dialogue.GoNextDialog();
        }
        else if(firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 6)
        {
            dialogue.GoNextDialog();
        }
        else if (firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 7)
        {
            ArrowBox.transform.DOLocalMoveY(-25f, 1f);
            ArrowBox.transform.DOLocalMoveX(-300f, 2f);
        }
        
    }

    public void tutoCaraSelected()
    {
        if(firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 7)
        {
            dialogue.GoNextDialog();
            ArrowBox.transform.DOLocalMoveX(140f, 2f);
            ArrowBox.transform.DOLocalMoveY(-255f, 2f);
            
        }
        else if (firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 8)
        {
            dialogue.GoNextDialog();
            print("aller dialogue 9");
        }
    }
    public void tutoValidated()
    {
        ArrowBox.SetActive(false);
        ArrowTwoD.SetActive(false);
    }

}
