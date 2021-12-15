using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TwoDTuto : MonoBehaviour
{

    public FirsttimeTutorial firsTimeTutorial;

    public GameObject ArrowTwoD;

    public GameObject ArrowBox;

    public GameObject PointerArrowTuto;

    public Dialogue dialogue;

    public Animator anim_TwoArrow;

    public Animator anim_DialogueBox;

    public GameObject RecoltPastelObject;

    // Start is called before the first frame update
    void Start()
    {
        ArrowTwoD.SetActive(true);
        anim_TwoArrow.GetComponent<Animator>();
        anim_DialogueBox.GetComponent<Animator>();
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
            ArrowTwoD.SetActive(false);

            anim_TwoArrow.SetTrigger("Enter");
        }
        else if (dialogue.DialogueCount == 10)
        {
            ArrowTwoD.SetActive(false);
            ArrowBox.SetActive(true);
        }
        else if (dialogue.DialogueCount == 12)
        {
            ArrowTwoD.SetActive(true);
            ArrowBox.SetActive(false);
        }


        if (firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount! <= 2)
        {
            RecoltPastelObject.GetComponent<Button>().interactable = false;

            print("il doit ne pas s'activer");
        }

        else if (firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount! == 3)
        {
            RecoltPastelObject.GetComponent<Button>().interactable = true;
            print("il doit s'activer !");
        } 
        
        else if (firsTimeTutorial.isFirstTime == false && dialogue.DialogueCount! == 16)
        {
            RecoltPastelObject.GetComponent<Button>().interactable = true;
            print("il doit s'activer !");
        }




    }

    //méthode pas la plus opti du tout car le joueur peut limite faire n'imp avec le tuto mais suffisant pour un proto
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
            anim_DialogueBox.SetTrigger("EnterFirst");
            dialogue.GoNextDialog();
        }
        else if (firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 7)
        {
            ArrowBox.transform.DOLocalMoveY(-25f, 1f);
            ArrowBox.transform.DOLocalMoveX(-400f, 2f);
        }
        else if (firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 10)
        {
            ArrowBox.transform.Rotate(new Vector3(180f, 0f, 0f));
            ArrowBox.transform.DOLocalMoveX(500f, 2f);
            ArrowBox.transform.DOLocalMoveY(190f, 2f);
            dialogue.GoNextDialog();
        }
        
        else if (firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 15)
        {
            ArrowBox.SetActive(false);
        }
      
        if (firsTimeTutorial == false)
        {
            print("ne fait rien");
        }
        
    }

    public void tutoCaraSelected()
    {
        if(firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 7)
        {
            dialogue.GoNextDialog();
            ArrowBox.transform.DOLocalMoveX(140f, 2f);
            ArrowBox.transform.DOLocalMoveY(-280f, 2f);
            
        }
        else if (firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 8)
        {
            dialogue.GoNextDialog();
            print("aller dialogue 9");
        }
        if (firsTimeTutorial == false)
        {
            print("ne fait rien");
        }

    }
    public void inTuto()
    {
        if (firsTimeTutorial == false)
        {
            print("ne fait rien");
        }
    }

    public void tutoValidated()
    {
        ArrowBox.SetActive(false);
        ArrowTwoD.SetActive(false);
    }

    public void ReSetActive()
    {
        if(firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 9)
        {
            ArrowBox.SetActive(true);
            ArrowTwoD.SetActive(true);
            anim_TwoArrow.SetTrigger("Enter");
            dialogue.GoNextDialog();

        }
        else if (firsTimeTutorial == false && dialogue.DialogueCount == 0)
        {
            print("ne fait rien");
        }
    }
    public void ReSetSetActiveFalse()
    {
        if(firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 11)
        {
            dialogue.GoNextDialog();
        }
        else if (firsTimeTutorial == false)
        {
            print("ne fait rien");
        }

    }

    public void CheckPastelCollect()
    {

        if(firsTimeTutorial.isFirstTime == true && dialogue.DialogueCount == 4)
        {
            RecoltPastelObject.GetComponent<Button>().interactable = false;

        }
    }
}
