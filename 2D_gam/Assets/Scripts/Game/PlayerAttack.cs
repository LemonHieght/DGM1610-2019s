﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Fire");
            if(other.gameObject.tag == "Enemy")
            {

                Destroy(other.gameObject);
            }
        }
    }
}
