using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjects : MonoBehaviour
{
    //to check if it was setted in a place
    public bool Setted;

    private Camera cam;
    private ManageObjects manageObjects;
    private Ray ray;
    private RaycastHit hit;
    private bool isGrounded;

    private void Awake()
    {
        cam = FindObjectOfType<Camera>();
        manageObjects = FindObjectOfType<ManageObjects>();
        isGrounded = cam.GetComponent<RayCam>().IsHitGround;
    }
    private void Update()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Input.GetButtonDown("Fire1") && gameObject.CompareTag(Tags.PlaceHolder))
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    CheckSelectable(manageObjects.SelectableObject);
                }
            }
        }
    }

    private void CheckSelectable(string name)
    {
        manageObjects.SetNewObject(name);
    }
}
