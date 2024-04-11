using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public string state;
    public GameObject player;
    public GameObject protector;
    public float followDistance;
    public Transform transformToFollow;
    private UnityEngine.AI.NavMeshAgent agent;
    Animator animator;
    Animator protectorAnimator;

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
            case "Look at Protector":
                FollowProtector();
                animator.Play("Running");
                break;
            case "Die":
                animator.Play("Dying Backwards");
                break;
        }
    }

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        CheckBehaviour();
    }
    void FollowPlayer()
    {
        agent.destination = transformToFollow.position;
    }
    void FollowProtector()
    {
        // transformToFollow = protector.transform;
        agent.destination = protector.transform.position;
    }

    void CheckBehaviour()
    {
        GetState();
        Act();
    }

    void GetState()
    {
        float playerDistance = (player.transform.position - transform.position).magnitude;
        float protectorDistance = (protector.transform.position - transform.position).magnitude;
        if (playerDistance >= 8 && playerDistance <= 30)
        {
            state = "Follow";
        }
        else if (playerDistance <= 7 && protectorDistance == 6)
        {
            state = "Look at Protector";

        }
        else if (protectorDistance <= 2)
        {
            state = "Attack";
        }
    }
}
