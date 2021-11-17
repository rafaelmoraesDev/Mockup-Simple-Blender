using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPointer : MonoBehaviour
{
    //to check if it was setted in a place
    public bool Setted;

    private Camera cam;
    private Ray ray;
    private RaycastHit hit;

    [SerializeField]
    private float folowSpeed;

    private void Awake()
    {
        cam = FindObjectOfType<Camera>();
    }
    private void LateUpdate()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag(Tags.Grid))
            {
                transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * folowSpeed);
            }
        }
    }
}
