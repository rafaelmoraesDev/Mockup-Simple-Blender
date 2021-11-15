using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPointer : MonoBehaviour
{
    //to check if it was setted in a place
    private bool setted;
    private Camera cam;
    private void Awake()
    {
        cam = FindObjectOfType<Camera>();
    }

    private void FixedUpdate()
    {
        // TODO if the object is not setted it could move freely, else set in place clicked
        if (!setted)
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit raycastHit))
            {
                transform.position = raycastHit.point;
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            setted = !setted;
            this.enabled = !enabled;
        }
    }


}
