using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class CamButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Transform CameraTransform;

    [SerializeField]
    private GameObject toolTip;

    private Camera mainCam;


    private void Awake()
    {
        mainCam = Camera.main;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        toolTip.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        toolTip.SetActive(false);
    }

    public void ResetCamera()
    {
        mainCam.transform.position = new Vector3(3f, 3f, -3f);
        mainCam.transform.rotation = Quaternion.Euler(30, -45, 0);

    }

}
