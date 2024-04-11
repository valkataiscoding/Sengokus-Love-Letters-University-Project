﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public float accel = 0.8f;
    public float inertia = 0.9f;
    public float speedLimit = 10.0f;
    public float minSpeed = 1.0f;
    public float stopTime = 1.0f;

    private float currentSpeed = 0.0f;

    private float functionState = 0;

    private bool accelState;
    private bool slowState;

    private Transform waypoint;
    public float rotationDamping = 6.0f;
    public bool smoothRotation = true;
    public Transform[] waypoints;
    private int WPindexPointer;
 
 
    void Start()
    {
        functionState = 0;
    }


    void Update()
    {
        if (functionState == 0)
        {
            Accell();
        }
        if (functionState == 1)
        {
            StartCoroutine(Slow());
        }
        waypoint = waypoints[WPindexPointer];
    }


    void Accell()
    {
        if (accelState == false)
        {
            accelState = true;
            slowState = false;
        }
        if (waypoint)
        {
            if (smoothRotation)
            {
                var rotation = Quaternion.LookRotation(waypoint.position - transform.position);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
            }
        }
        currentSpeed = currentSpeed + accel * accel;
        transform.Translate(0, 0, Time.deltaTime * currentSpeed);

        if (currentSpeed >= speedLimit)
        {
            currentSpeed = speedLimit;
        }
    }


    void OnTriggerEnter()
    {
        functionState = 1;
        WPindexPointer++;

        if (WPindexPointer >= waypoints.Length)
        {
            WPindexPointer = 0;
        }
    }


    IEnumerator Slow()
    {
        if (slowState == false)
        {
            accelState = false;
            slowState = true;
        }

        currentSpeed = currentSpeed * inertia;
        transform.Translate(0, 0, Time.deltaTime * currentSpeed);

        if (currentSpeed <= minSpeed)
        {
            currentSpeed = 0.0f;
            yield return new WaitForSeconds (stopTime);
            functionState = 0;
        }
    }

}
