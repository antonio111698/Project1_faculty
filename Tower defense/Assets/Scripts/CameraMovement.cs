using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Transform targetToFollow;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -11.5f, 11.0f),
                                        Mathf.Clamp(targetToFollow.position.y, -4.9f, 4.9f),
                                        transform.position.z);
    }


}
