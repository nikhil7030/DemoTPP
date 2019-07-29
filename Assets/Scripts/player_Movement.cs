using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Movement : MonoBehaviour
{
    public Rigidbody Player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Player.AddForce(0,0,20);
        }
        if (Input.GetKeyDown("a"))
        {
            Player.AddForce(5,0,20);
        }
        if (Input.GetKeyDown("d"))
        {
            Player.AddForce(-5,0,20);
        }
        if (Input.GetKeyDown("s"))
        {
            Player.AddForce(0,0,-20);
        }
    }
}
