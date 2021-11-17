using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPieceInPlace : MonoBehaviour
{
    private FollowPointer followPointer;

    private void Awake()
    {
        followPointer = GetComponent<FollowPointer>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (followPointer.enabled)
            {
                followPointer.Setted = !followPointer.enabled;
                followPointer.enabled = !followPointer.enabled;
            }
        }
    }
}
