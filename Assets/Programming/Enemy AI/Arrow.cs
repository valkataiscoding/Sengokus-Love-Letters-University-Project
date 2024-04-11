using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;

public class Arrow : MonoBehaviour
{
    Animator enemyAnimator;
    //GameObject enemy;

    //public Arrow(GameObject enemy)
    //{
    //    this.enemy = enemy;
    //}

    //public void AnimateArrow()
    //{
    //    Rigidbody tempRigidBodyArrow = this.GetComponent<Rigidbody>();
    //    Vector3 tempVect = enemy.transform.position - this.transform.position;
    //    tempVect = tempVect.normalized * 30f * Time.deltaTime;
    //    tempRigidBodyArrow.AddForce(tempVect * 60);
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            
            enemyAnimator = other.gameObject.GetComponent<Animator>();

            enemyAnimator.Play("Dying Backwards");
           

            Destroy(this.gameObject,1f);
            Destroy(other.gameObject, 5f);

        }
    }
}
