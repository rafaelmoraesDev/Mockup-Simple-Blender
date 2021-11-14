using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageObjects : MonoBehaviour
{
    public GameObject PrefabCube;
    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Vector3 cursorPos = Input.mousePosition;
            GameObject go = Instantiate(PrefabCube, cursorPos, Quaternion.identity);
            go.transform.position = new Vector3(cursorPos.x, cursorPos.y);
            //Generator();
        }
    }

    //private void Generator()
    //{
    //    GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //    go.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    go.AddComponent<MeshCollider>();
    //    go.AddComponent<FollowPointer>();
    //}

}
