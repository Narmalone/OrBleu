using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDTuto : MonoBehaviour
{

    public FirsttimeTutorial firsTimeTutorial;

    public GameObject ArrowTwoD;

    public Dialogue dialogue;



    // Start is called before the first frame update
    void Start()
    {
        ArrowTwoD.SetActive(true);
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
    }

}
