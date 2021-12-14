using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    [TextArea(0,4)] public string[] lines;
    public FirsttimeTutorial firstTimeTurorial;


    public float textSpeed;

    public int DialogueCount;
    private int index;

    public PointerTutorial pointertutorial;

    public Animator DialogueBoxAnim;



    // Start is called before the first frame update
    void Start()
    {
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

    //Début du dialoqgue
    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    //Va lire les lettres et les ajouter 1 à 1
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

    //aller au dialogue suivant//
    public void GoNextDialog()
    {

        if (textComponent.text == lines[index])
        { 
            DialogueCount++;
            nextLine();
            pointertutorial.Update();
            //print(DialogueCount);
        }
        else
        {
            if (DialogueCount == 6)
            {
                DialogueCount++;
                nextLine();
                print("doit passer à 7");
            }

            else if(DialogueCount == 7)
            {
                DialogueCount++;
                nextLine();
                print("doit passer à 8");
            }
            else if(DialogueCount == 8)
            {
                DialogueCount++;
                nextLine();
                print("doit passer à 9");
            }
            else if(DialogueCount == 10)
            {
                DialogueCount++;
                nextLine();
                print("doit passer à 11");
            }
           

            StopAllCoroutines();
            textComponent.text = lines[index];
        }
    }
}
