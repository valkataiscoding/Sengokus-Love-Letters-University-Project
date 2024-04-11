using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtectorAI : MonoBehaviour
{
    private bool canAttack = false;
    private bool isFollowing = true;
    public Transform transformToFollow;
    Animator animator;
    private UnityEngine.AI.NavMeshAgent agent;

    // Update is called once per frame
    private void Update()
    {
        if (isFollowing && !canAttack)
        {
            agent.destination = transformToFollow.position;
            animator.Play("Running");
        }
        if (canAttack)
        {
            animator.Play("Standing Melee Attack Downward");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isFollowing = false;
            canAttack = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            isFollowing = true;
            canAttack = false;
        }
    }
}
