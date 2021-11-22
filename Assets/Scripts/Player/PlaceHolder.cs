using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolder : MonoBehaviour
{
    private float height = 20;
    private RaycastHit hit;

    private void Update()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(transform.position, Vector3.down * height, Color.yellow);

        transform.position = Camera.main.GetComponent<RayCam>().IntersectPoint;
        //transform.LookAt(Camera.main.transform);
    }
}
