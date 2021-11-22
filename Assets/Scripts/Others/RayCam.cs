using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCam : MonoBehaviour
{
    public Vector3 IntersectPoint;
    public float distance = 100f;

    public bool IsHitGround;

    private void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.red);
        RaycastHit hitPoint;

        if (Physics.Raycast(ray, out hitPoint, distance))
        {
            IntersectPoint = hitPoint.point;
            IntersectPoint.y = 0.5f;
        }
    }
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag(Tags.Grid))
            {
                IsHitGround = true;
            }
        }
        else
        {
            IsHitGround = false;
        }
    }
}
