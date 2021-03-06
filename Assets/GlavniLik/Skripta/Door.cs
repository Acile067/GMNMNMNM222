﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private PlayerGo thePlayer;

    
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerGo>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followTarget = transform;
            }
        }
    }
}
