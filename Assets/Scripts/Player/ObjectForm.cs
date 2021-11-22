using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectForm : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private float distance = 10;
    private Outline outline;

    private void Start()
    {
        outline = GetComponent<Outline>();
    }


    private void FixedUpdate()
    {
        Vector3 down = transform.TransformDirection(Vector3.down) * distance;


        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag(Tags.Grid))
            {
                transform.position = hit.point;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Vector3 down = transform.TransformDirection(Vector3.down) * 10;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag(Tags.Grid))
            {
                Debug.DrawRay(transform.position, down, Color.green);
                print("hit grid");
            }
            else
            {
                print("not hit grid");
                Debug.DrawRay(transform.position, down, Color.red);

            }
        }
    }
    public void OnMouseOver()
    {
        outline.enabled = true;
    }

    public void OnMouseExit()
    {
        outline.enabled = false;
    }

}
