using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;
using TMPro;

[RequireComponent(typeof(ARRaycastManager))]
public class PlaceObject : MonoBehaviour
{
    public GameObject ObjectToPlace;
    public GameObject Canvas;

    public GameObject spawnObj;
    private ARRaycastManager rayMan;
    private Vector2 touchPos;
    public Vector3 lastPos;

    public TextMeshProUGUI lastposText;

    public bool moveObj=true;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();


    private void Awake()
    {
        rayMan = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPos)
    { 
        if (Input.touchCount > 0 && EventSystem.current.currentSelectedGameObject == null)
        {
                touchPos = Input.GetTouch(0).position;
                return true;
        }
        touchPos = default;
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        lastposText.text = lastPos.ToString();
        

        if (!TryGetTouchPosition(out Vector2 touchPos))
            return;

        
            
        if (rayMan.Raycast(touchPos, hits, TrackableType.PlaneWithinPolygon))
        {
            
            var hitPose = hits[0].pose;

            if (spawnObj == null)
            {
                    spawnObj = Instantiate(ObjectToPlace, hitPose.position, hitPose.rotation);
                    Canvas.GetComponent<UImanager>().Cube = spawnObj;
            }
            else
            { 
               
              if (moveObj == true) { spawnObj.transform.position = hitPose.position; lastPos = hitPose.position;}
              else { spawnObj.transform.position = lastPos; }
              
                       
            }
        }


        

    }
}
