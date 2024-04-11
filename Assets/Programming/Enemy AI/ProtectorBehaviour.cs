using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ProtectorBehaviour : MonoBehaviour
{
    public string state;
    public GameObject player;
    public float followDistance;
    public Transform transformToFollow;
    private NavMeshAgent agent;
    Animator animator;
    private bool canAttack = false;

    void Act()
    {
        switch (state)
        {
            case "Attack":
                animator.Play("Standing Melee Attack Downward");
                break;
            case "Follow":
                FollowPlayer();
                animator.Play("Running");
                break;
        }
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        CheckBehaviour();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("canAttack");
            canAttack = true;
        }
    }

        void FollowPlayer()
    {
        agent.destination = transformToFollow.position;
    }

    void CheckBehaviour()
    {
        GetState();
        Act();
    }

    void GetState()
    {
        float playerDistance = (player.transform.position - transform.position).magnitude;
        if (playerDistance >= 6 && playerDistance <= 50)
        {
            state = "Follow";
        }
        if (canAttack)
        {
            state = "Attack";
        }
    }
}

