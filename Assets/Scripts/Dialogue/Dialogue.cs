using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    [TextArea(0,3)] public string[] lines;
    public FirsttimeTutorial firstTimeTurorial;


    public float textSpeed;

    public int DialogueCount;
    private int index;

    public PointerTutorial pointertutorial;

    public Animator DialogueBoxAnim;



    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        DialogueCount = 0;

        DialogueBoxAnim.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueCount == 11)
        {
            DialogueBoxAnim.SetTrigger("EnterSecond");
        }
        else if (DialogueCount == 15)
        {
            firstTimeTurorial.isFirstTime = false;
            print("Le joueur n'est plus dans le tuto");
        }
    }

    //D�but du dialoqgue
    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    //Va lire les lettres et les ajouter 1 � 1
    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed*Time.deltaTime);
        }
    }

    //Si y'a plus de lettres on vide
    void nextLine()
    {
        if(index< lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    //passer au dialogue suivant => modif vers le PointerTutorial//
    public void GoNextDialog()
    {

       

        if (textComponent.text == lines[index])
        {
            nextLine();
            DialogueCount++;
            pointertutorial.Update();
            //print(DialogueCount);
        }
        else
        {
            StopAllCoroutines();
            textComponent.text = lines[index];
        }
    }

    //Faire monter la boite de dialogue
    public void UpDialog()
    {
       
    }

}
