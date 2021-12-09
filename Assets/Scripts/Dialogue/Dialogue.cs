using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    [TextArea(0,3)] public string[] lines;

    public GameObject dialogueBox;


    public float textSpeed;

    public int DialogueCount;
    private int index;

    public PointerTutorial pointertutorial;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        DialogueCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
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

    //passer au dialogue suivant => modif vers le PointerTutorial//
    public void GoNextDialog()
    {
        if(textComponent.text == lines[index])
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
        if (DialogueCount == 7)
        {
            dialogueBox.transform.DOMoveY(700f, 2f);
        }
        else 
        {
            print("la boite ne bouge pas");
        }
    }

}
