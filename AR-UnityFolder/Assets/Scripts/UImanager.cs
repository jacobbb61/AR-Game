using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UImanager : MonoBehaviour
{
    public GameObject Level;
    public GameObject Open, Close;
    public GameObject ScaleObj;
    public GameObject ARSessionOrigin;

    public TextMeshProUGUI moveObjText;
    public TextMeshProUGUI moveBallText;

    public bool openUI;
    public bool moveObject = true;


    public float scale;

    private void Start()
    {
        Level = GameObject.FindGameObjectWithTag("Level");
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
        Level.transform.localScale = new Vector3(scale,scale,scale);
     

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



    }


    public void Button()
    {
        openUI =! openUI;
        Level.GetComponent<LevelManager>().ReBuildNavMesh();
    }
    public void ButtonMoveObject()
    {
        moveObject = !moveObject;
    }


}
