using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 mouseOffset;
    private float mouseCoordZ;

    private void OnMouseDown()
    {
        mouseCoordZ = Camera.main.WorldToScreenPoint(transform.position).z;
        mouseOffset = transform.position - GetWorldMousePos();
    }

    private Vector3 GetWorldMousePos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mouseCoordZ;
        mousePoint.y = Camera.main.GetComponent<RayCam>().IntersectPoint.y;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetWorldMousePos() + mouseOffset;
    }

}
