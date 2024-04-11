using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    public Vector3 myPos;
    public Transform myPlay;

    // Update is called once per frame
    public void Update()
    {
        transform.position = myPlay.position + myPos;
    }
}
