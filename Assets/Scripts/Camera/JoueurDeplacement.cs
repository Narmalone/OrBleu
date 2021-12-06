using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class JoueurDeplacement : MonoBehaviour
{


    public int speed = 2;
    public float XZSpeed = 0.05f;

    public float speedDefilement;

    public Camera selectedCamera;

    public float minPinchSpeed = 5.0F;
    public float varianceInDistances = 5.0F;
    private float touchDelta = 0.0F;

    [SerializeField]
    private float maxLeft  = -50;
    [SerializeField]
    private float maxRight = 50;

    private Vector2 prevDist = new Vector2(0, 0);
    private Vector2 curDist = new Vector2(0, 0);

    private float speedTouch0 = 0.0F;
    private float speedTouch1 = 0.0F;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved )
        {
            //A TESTER POUR LIMITES DE CAMERAS//
            //Mathf.Clamp(transform.position.x, minLeft, maxRight);


            //transform.position = new Vector3(

                //transform.position.x,
                //transform.position.y,
                //Mathf.Clamp(transform.position.z, maxLeft, maxRight)
                //);



            //AJOUTER UN CHAMP QUI EMPECHE DALLER DE GAUCHE A DROITE//

            Vector3 TouchDeltaPosition = Input.GetTouch(0).deltaPosition;
            //Vector3 TouchDeltaPositionZ = Input.GetTouch(0).deltaPosition;

            transform.Translate(-TouchDeltaPosition.x * XZSpeed * Time.deltaTime, 0f, 0f);
            //transform.Translate(0f, 0f, TouchDeltaPositionZ.z * XZSpeed * Time.deltaTime);

            speedTouch0 = Input.GetTouch(0).deltaPosition.magnitude / Input.GetTouch(0).deltaTime;


        }

        if (Input.touchCount == 2 && Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved)
        {

            curDist = Input.GetTouch(0).position - Input.GetTouch(1).position; //current distance between finger touches
            prevDist = ((Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition) - (Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition)); //difference in previous locations using delta positions
            touchDelta = curDist.magnitude - prevDist.magnitude;
            speedTouch0 = Input.GetTouch(0).deltaPosition.magnitude / Input.GetTouch(0).deltaTime;
            speedTouch1 = Input.GetTouch(1).deltaPosition.magnitude / Input.GetTouch(1).deltaTime;



            if ((touchDelta + varianceInDistances <= 1) && (speedTouch0 > minPinchSpeed) && (speedTouch1 > minPinchSpeed))
            {

                selectedCamera.fieldOfView = Mathf.Clamp(selectedCamera.fieldOfView + (1 * speed), 15, 90);

                //selectedCamera.transform.position = 
            }

            if ((touchDelta + varianceInDistances > 1) && (speedTouch0 > minPinchSpeed) && (speedTouch1 > minPinchSpeed))
            {

                selectedCamera.fieldOfView = Mathf.Clamp(selectedCamera.fieldOfView - (1 * speed), 15, 90);


            }

        }



    }

    public void OnCredit()
    {
        selectedCamera.transform.position = transform.position + new Vector3(0.3f * Time.deltaTime, 0.3f * Time.deltaTime, 0.3f * Time.deltaTime);
    }



}