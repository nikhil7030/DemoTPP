using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    GameObject[] _player;
    Vector3 player_Position;
    public Vector3 OffSet;
    

    void Start()
    {
        _player = GameObject.FindGameObjectsWithTag("Player");
        player_Position = new Vector3();
        
    }

    
    void FixedUpdate()
    {
        
        player_Position = _player[0].transform.position + OffSet;
        transform.position = player_Position;
        
    }
}
