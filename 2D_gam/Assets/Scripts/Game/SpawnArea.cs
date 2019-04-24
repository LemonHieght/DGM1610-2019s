﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour
{
    public int spawnAmount = 1;
    public float waitTime = 100;
    public float waitTimeCounter;
    public GameObject enemy;
    public Vector3 center;
    public Vector3 size; 
    public int liveEnemys;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(waitTimeCounter > 0)
        {
            waitTimeCounter -= Time.deltaTime;
        }
        if(waitTimeCounter <= 0)
        {
            SpawnEnemy();
            spawnAmount += 1;
            waitTimeCounter = waitTime;
            if(liveEnemys == 0)
            {
                waitTimeCounter = 1;

            }
            
        }
    }

    public void SpawnEnemy()
    {
        for(int i = 0; i < spawnAmount; i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x /2), Random.Range(-size.y / 2, size.y / 2), 0f);
            Instantiate(enemy , pos, Quaternion.identity);
            liveEnemys++;
        }
        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(center, size);
    }
}
