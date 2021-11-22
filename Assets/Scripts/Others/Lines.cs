using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lines : MonoBehaviour
{
    public Plane plane;


    private LineRenderer lineAxis;
    // Start is called before the first frame update
    void Start()
    {
        lineAxis = GetComponent<LineRenderer>();
        
    }

}
