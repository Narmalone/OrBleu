using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{


   //ACTIVER INTERFACES
    public void SetActiveObject(GameObject _obj)
    {
        _obj.SetActive(true);
    }
    //DESACTIVER INTERFACE
    public void SetDisableObject(GameObject _obj)
    {
        _obj.SetActive(false);

    }
    //ALLER PARAMETRES SONS
    public void goVolume(GameObject _obj)
    {
        _obj.SetActive(true);
    }

    public void SetActiveFarmObject(GameObject _obj)
    {
        _obj.SetActive(true);
    }

}
