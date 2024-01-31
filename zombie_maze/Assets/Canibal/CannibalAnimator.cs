using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.AI;

public class CannibalAnimator : MonoBehaviour
{
    NavMeshAgent agent;
    Animator animator;
    [SerializeField] GameObject referenceObject;
    public float radius = 1f;
    public LayerMask target;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {

        bool isColliding = Physics.CheckSphere(transform.position, radius,target);

        if (isColliding)
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Attack1", true);
            
        }
        else
        {
            animator.SetBool("Attack1", false);
            animator.SetBool("Walk", true);

            // Add code here to make the cannibal follow the player using the NavMeshAgent
            // For example:
            agent.SetDestination(referenceObject.transform.position);
        }


    }
}



   /* public void Walk()
    {

        animator.SetBool("Walk", walk);
    }*/


