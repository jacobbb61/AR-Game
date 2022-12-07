using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UImanager : MonoBehaviour
{
    public GameObject Cube, Ball;
    public GameObject Open, Close;
    public GameObject HeightObj, ScaleObj;
    public GameObject ARSessionOrigin;

    public TextMeshProUGUI moveObjText;
    public TextMeshProUGUI moveBallText;

    public bool openUI;
    public bool moveObject = true;
    public bool moveBall = true;

    public float scale;
    public float Ypos;
    private void Start()
    {
        Cube = GameObject.FindGameObjectWithTag("Player");
        Ball = GameObject.FindGameObjectWithTag("Ball");
    }


    void Update()
    {
        if (openUI)
        {
            Open.SetActive(true);
            Close.SetActive(false);
        }else
        {
            Open.SetActive(false);
            Close.SetActive(true);
        }

        scale = ScaleObj.GetComponent<Slider>().value;
        Cube.transform.localScale = new Vector3(scale,scale,scale);
        Cube.transform.position = new Vector3(Cube.transform.position.x, HeightObj.GetComponent<Slider>().value, Cube.transform.position.z);

        if (moveObject)
        {
            moveObjText.text = "On";
            ARSessionOrigin.GetComponent<PlaceObject>().moveObj = true;
        }
        else
        {
            moveObjText.text = "Off";
            ARSessionOrigin.GetComponent<PlaceObject>().moveObj = false;
        }
        if (moveBall)
        {
            moveBallText.text = "Ball";
           // ARSessionOrigin.GetComponent<RotateSide>().enabled = false;
            Ball.GetComponent<BallMovement>().enabled = true;
        }
        else
        {
            moveBallText.text = "Sides";
           // ARSessionOrigin.GetComponent<RotateSide>().enabled = true;
            Ball.GetComponent<BallMovement>().enabled = false;
            Ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }


    }


    public void Button()
    {
        openUI =! openUI;
    }
    public void ButtonMoveObject()
    {
        moveObject = !moveObject;
    }
    public void ButtonMoveBall()
    {
        moveBall = !moveBall;
    }

}
