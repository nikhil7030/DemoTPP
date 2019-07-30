using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_Controls : MonoBehaviour
{
    
    public Input`Controller controls;
    public Animator anim;
    

    void Awake()
    {
        controls.Player.Attack.performed += ctx => Attack1();
        controls.Player.Attack2.performed += ctx => Attack2();

    }
    void Attack1()
    {
        anim.Play("downtoupslash");
    }
    void Attack2()
    {
        anim.Play("uptodownslash");
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }
}
