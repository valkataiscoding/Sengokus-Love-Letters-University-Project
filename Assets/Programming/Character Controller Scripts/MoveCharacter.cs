﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = 4.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -0.5f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0.5f, 0);
        }
    }
}
