using UnityEngine;
using System.Collections;

public class SwipeInputScript : MonoBehaviour
{
    //Swiping Script. Currently tested only with mouse, and line number 45 should be inspected again. Swiping only works when the swipe is fast.

    private Vector2 fingerStart;
    private Vector2 fingerEnd;

    // Update is called once per frame
    void Update()
    {
        //foreach (Touch touch in Input.touches)
        //{
        //if (touch.phase == TouchPhase.Began)
        if (Input.GetMouseButtonDown(0))
        {
            //fingerStart = touch.position;
            //fingerEnd = touch.position;
            fingerStart = Input.mousePosition;
            fingerEnd = Input.mousePosition;
            Debug.Log("Pressed");

        }
        //if (touch.phase == TouchPhase.Moved)
        if (Input.GetMouseButton(0))
        {
            //fingerEnd = touch.position;
            fingerEnd = Input.mousePosition;

            if ((fingerStart.x - fingerEnd.x) > 80 ||
               (fingerStart.x - fingerEnd.x) < -80) // Side to side Swipe
            {
                Debug.Log("Side Swipe");
            }
            else if ((fingerStart.y - fingerEnd.y) < -80 ||
                    (fingerStart.y - fingerEnd.y) > 80) // top to bottom swipe
            {
                Debug.Log("Vertical Swipe");
            }

            //After the checks are performed, set the fingerStart & fingerEnd to be the same
            //fingerStart = touch.position;
            fingerStart = Input.mousePosition;
        }
        //if (touch.phase == TouchPhase.Ended)
        if (Input.GetMouseButtonUp(0))
        {
            fingerStart = Vector2.zero;
            fingerEnd = Vector2.zero;
        }
        //}
    }
}
