using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;
    private bool isWalking = false;
    

    
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray, out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
        if(agent.remainingDistance <= agent.stoppingDistance)
        {
            isWalking = false;
        }
        else
        {
            isWalking = true;
        }

        animator.SetBool("isWalking",isWalking);
    }

   

}
