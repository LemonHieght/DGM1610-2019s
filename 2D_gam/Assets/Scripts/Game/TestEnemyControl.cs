﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyControl : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    //private Rigidbody2D myRigidbody;
    private Animator anim;
    public float reloadWait;
    private bool reloading;

    // Start is called before the first frame update
    void Start()
    {
       //myRigidbody = GetComponent<Rigidbody2D>();
       anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //movement system
        if(player.transform.position.x + 0.2f > gameObject.transform.position.x)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x + moveSpeed * Time.deltaTime, gameObject.transform.position.y);
            //myRigidbody.velocity = new Vector2(myRigidbody.velocity.x * moveSpeed, myRigidbody.velocity.y);
            anim.SetBool("Move", true);
        }
        if(player.transform.position.x - 0.2f < gameObject.transform.position.x)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x - moveSpeed * Time.deltaTime, gameObject.transform.position.y);
            anim.SetBool("Move", true);
        }
        if(player.transform.position.y + 0.2f > gameObject.transform.position.y)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + moveSpeed * Time.deltaTime);
            anim.SetBool("Move", true);
        }
        if(player.transform.position.y - 0.2f < gameObject.transform.position.y)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - moveSpeed * Time.deltaTime);
            anim.SetBool("Move", true);
        }

        //restarts the level over
        if(reloading)
        {
            reloadWait -= Time.deltaTime;
            if(reloadWait < 0)
            {
                Application.LoadLevel(Application.loadedLevel);
                player.SetActive(true);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        //"kills" the player by auto start new level
        if(player)
        {
            //Destroy/kill Player
            player.SetActive(false);
            reloading = true;

        }
    }
}