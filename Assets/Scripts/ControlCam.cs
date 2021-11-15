using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCam : MonoBehaviour
{

    public Transform Target;
    public Vector3 IntersectPoint;
    private Camera cam;

    [SerializeField]
    private float zoomSpeed = 200f;
    private void Start()
    {
        cam = Camera.main;
    }

    private void FixedUpdate()
    {
        transform.LookAt(Target);
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        ZoomCamera(cam.fieldOfView -= scroll);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.red);
        RaycastHit hitPoint;

        if (Physics.Raycast(ray, out hitPoint, 100f))
        {
            IntersectPoint = hitPoint.point;
        }
    }
    private void ZoomCamera(float target)
    {
        cam.fieldOfView = Mathf.MoveTowards(cam.fieldOfView, target, (zoomSpeed * Time.deltaTime) + 2f);
    }
}
