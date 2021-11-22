using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ManageObjects : MonoBehaviour
{
    public List<GameObject> Prefabs;
    public List<GameObject> PlaceHolders;
    public List<GameObject> Objecs;
    public string SelectableObject;

    private RayCam rayCam;
    private GameObject target;
    private GameObject placeHolder;

    private void Awake()
    {
        DisablePlaceHolders();
    }
    private void Start()
    {
        rayCam = Camera.main.GetComponent<RayCam>();
    }
    private void Update()
    {
        if (placeHolder != null)
        {
            if (rayCam.IsHitGround)
            {
                placeHolder.SetActive(true);
            }
            else
            {
                placeHolder.SetActive(false);
            }
        }
    }
    public void SetPLaceHolder()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        string[] info = buttonName.Split('_');
        SelectableObject = info[info.Length - 1];

        ActivatePlaceHolder(SelectableObject);
    }

    public void SetNewObject(string name)
    {
        DisablePlaceHolders();
        name = SelectableObject;
        foreach (GameObject item in Prefabs)
        {
            if (item.name.Contains(name))
                target = item;
        }

        GameObject go = Instantiate(target, rayCam.IntersectPoint, Quaternion.identity);
        go.name = name;
        Objecs.Add(go);
    }

    public void DisablePlaceHolders()
    {
        foreach (GameObject item in PlaceHolders)
        {
            item.SetActive(false);
            placeHolder = null;
        }
    }

    private void ActivatePlaceHolder(string name)
    {
        for (int i = 0; i < PlaceHolders.Count; i++)
        {
            if (PlaceHolders[i].name.Contains(name))
            {
                Camera cam = Camera.main;
                PlaceHolders[i].transform.position = cam.ScreenToWorldPoint(new Vector3
                    (Input.mousePosition.x, Input.mousePosition.y, 5f));
                placeHolder = PlaceHolders[i];
                PlaceHolders[i].SetActive(true);
            }
            else
            {
                PlaceHolders[i].SetActive(false);
            }
        }
    }
}
