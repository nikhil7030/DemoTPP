﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemie_Controler : MonoBehaviour
{
    public float lookRadius = 10f;

    public Transform target;
    public NavMeshAgent agent;
    Animator animator;

    void Start()
    {
        target = Player_Manager.instance.Player.transform;
        //agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();

    }

    
    void FixedUpdate()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            Debug.Log(target.position);
            animator.SetBool("Chase",true);
            if (distance <= agent.stoppingDistance)
            {
                animator.SetBool("Attack",true);
                Debug.Log("Attack");
                FaceTarget();
            }

        }
    }
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
