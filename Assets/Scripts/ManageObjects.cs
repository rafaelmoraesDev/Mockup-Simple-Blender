using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageObjects : MonoBehaviour
{
    public GameObject PrefabCube;
    public GameObject PrefabSphere;
    public GameObject PrefabCapsule;

    public GameObject PrefabCubePlaceHolder;
    public GameObject PrefabSpherePlaceHolder;
    public GameObject PrefabCapsulePlaceHolder;

    private RayCam rayCam;

    private void Start()
    {
        rayCam = Camera.main.GetComponent<RayCam>();
    }
    public void SetPLaceHolder()
    {
        GameObject placeHolder = Instantiate(PrefabCubePlaceHolder, rayCam.IntersectPoint, Quaternion.identity);
    }
    public void SetNewCube()
    {
        //GameObject cube = Instantiate(PrefabCube, Vector3.zero, Quaternion.identity);
        GameObject cube = Instantiate(PrefabCube, rayCam.IntersectPoint, Quaternion.identity);
    }
    public void SetNewSphere()
    {
        //GameObject sphere = Instantiate(PrefabSphere, Vector3.zero, Quaternion.identity);
        GameObject sphere = Instantiate(PrefabSphere, rayCam.IntersectPoint, Quaternion.identity);

    }
    public void SetNewCapsule()
    {
        //GameObject capsule = Instantiate(PrefabCapsule, Vector3.zero, Quaternion.identity);
        GameObject capsule = Instantiate(PrefabCapsule, rayCam.IntersectPoint, Quaternion.identity);

    }

}
