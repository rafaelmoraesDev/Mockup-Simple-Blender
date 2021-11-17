using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCam : MonoBehaviour
{
    public Vector3 IntersectPoint;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
        RaycastHit hitPoint;

        if (Physics.Raycast(ray, out hitPoint, 100f))
        {
            IntersectPoint = hitPoint.point;
            IntersectPoint.y = 0f;
        }
    }
}
