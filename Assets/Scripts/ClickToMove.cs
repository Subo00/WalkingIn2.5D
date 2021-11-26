using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    Animator animator;
    [SerializeField] private float speed;
    private Vector3 targetPosition;

    

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
       
        if(animator.GetBool("isWalking"))
        {
            Rotate();
            Move();
        }
    }

    void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;
        targetPosition.y = transform.position.y;

        animator.SetBool("isWalking",true);
    }

    void Move()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed* Time.deltaTime);
        if(transform.position == targetPosition)
        {
            animator.SetBool("isWalking",false);
        }
    }
    void Rotate()
    {
        Vector3 relativePos = targetPosition - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
    
}
