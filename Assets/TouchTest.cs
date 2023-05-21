using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    
    void Update()
    {
        if (Input.touchCount == 0)
        return;

        var touches = Input.touches;

        for (int i = 0; i < touches.Length; i++)
        {
            var touch = touches[i];
            switch (touch.phase)
            {
                case TouchPhase.Began:
                Debug.Log("Began" + i +""+touch.position);
                break;
                case TouchPhase.Stationary:
                Debug.Log("Stationary" + i +""+touch.position);
                break;
                case TouchPhase.Moved:
                Debug.Log("Moved" + i +""+touch.position);
                break;
                case TouchPhase.Ended:
                Debug.Log("Ended" + i +""+touch.position);
                break;
                case TouchPhase.Canceled:
                Debug.Log("Canceled" + i +""+touch.position);
                break;
            }
        }
        
    }
}
