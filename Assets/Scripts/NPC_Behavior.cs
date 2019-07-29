using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_Behavior : MonoBehaviour
{
    public float fieldOfViewAngel = 110f;
    public bool playerInSight;
    public Vector3 personalLastSighting;

    private NavMeshAgent nav;
    private SphereCollider col;
    private Animator anim;
    //private lastplayersighting lastplayersighting;
    private GameObject player;
    private Animator playeranim;
    

}
