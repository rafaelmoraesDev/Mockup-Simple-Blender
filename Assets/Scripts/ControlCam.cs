using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCam : MonoBehaviour
{

    public Transform Target;
    private Camera cam;

    [SerializeField]
    private float zoomSpeed = 200f;
    private void Start()
    {
        cam = Camera.main;
    }

    private void LateUpdate()
    {
        transform.LookAt(Target);
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        ZoomCamera(cam.fieldOfView -= scroll);
    }
    private void ZoomCamera(float target)
    {
        cam.fieldOfView = Mathf.MoveTowards(cam.fieldOfView, target, (zoomSpeed * Time.deltaTime) + 1f);
    }
}
