using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public Animator anim;
    public InputController controls;

    void Start()
    {

        controls.Player.Attack.performed += _ => Attack();
        controls.Player.Attack.canceled += _ => Attack_Cancel();

        controls.Player.Attack2.performed += ctx => Attack_Mode_On();
        controls.Player.Attack2.canceled += ctx => Attack_Mode_OFf();

    }
    void Attack()
    {
        anim.Play("Attack");
        Debug.Log("Left Key");
    }

    void Attack_Cancel()
    {
        anim.Play("Grounded");
    }
    void Attack_Mode_On()
    {
        //anim.Play("AttackMode");
        Debug.Log("Cancelled");
        anim.Play("AttackMode");
    }
    void Attack_Mode_OFf()
    {
        //anim.Play("AttackMode");
        Debug.Log("Cancelled");
        anim.Play("Grounded");
    }
    void Awake()
    {
        controls = new InputController();

    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }
    private void OnDisable()
    {
        controls.Player.Disable();
    }

    
}
