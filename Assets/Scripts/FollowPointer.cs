using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPointer : MonoBehaviour
{
    //to check if it was setted in a place
    private bool setted;

    private void Update()
    {
        // TODO if the object is not setted it could move freely, else set in place clicked
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(cursorPos.x, cursorPos.y);
    }
}
