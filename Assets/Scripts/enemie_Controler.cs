using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemie_Controler : MonoBehaviour
{
    public float lookRadius = 10f;

    public Transform target;
    public NavMeshAgent agent;

    void Start()
    {
        target = Player_Manager.instance.Player.transform;
        //agent = GetComponent<NavMeshAgent>();
    }

    
    void FixedUpdate()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            Debug.Log(target.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
