using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderAttackDialog : MonoBehaviour
{

    public GameObject underAttackDialog;

    public bool isUnderAttack;

    // Start is called before the first frame update
    void Start()
    {
        isUnderAttack = true;
        underAttackDialog.SetActive(true);
    }

    void resetUnderAttack()
    {
        underAttackDialog.SetActive(false);
        isUnderAttack = false;
    }
}
