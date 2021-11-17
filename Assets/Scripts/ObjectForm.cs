using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectForm : MonoBehaviour
{
    private Outline outline;
    private FollowPointer followPointer;

    private void Awake()
    {
        outline = GetComponent<Outline>();
        followPointer = GetComponent<FollowPointer>();
    }
    
    public void OnMouseOver()
    {
        outline.enabled = enabled;
    }

    public void OnMouseExit()
    {
        outline.enabled = !enabled;
        followPointer.enabled = !enabled;
    }

    public void OnMouseDrag()
    {
        followPointer.enabled = enabled;
    }
}
