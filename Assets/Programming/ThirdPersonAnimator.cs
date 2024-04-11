using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonAnimator : MonoBehaviour
{
    //private Animator animator;
    //private Rigidbody rigidBody;

    //private float speed = 3f;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    animator = this.GetComponent<Animator>();
    //    rigidBody = this.GetComponent<Rigidbody>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    animator.SetFloat("speed", rigidBody.velocity.magnitude / speed);
    //}

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        animator.SetFloat("Vertical", v);
        animator.SetFloat("Horizontal", h);
    }
}
