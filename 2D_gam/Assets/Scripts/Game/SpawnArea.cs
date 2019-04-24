﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour
{
    public int spawnAmount;
    public float spawnTime;
    public float spawnTimeCounter;
    public GameObject enemy;
    public Vector3 center;
    public Vector3 size; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(spawnTimeCounter > 0)
        {
            spawnTimeCounter -= Time.deltaTime;
        }
        if(spawnTimeCounter <= 0)
        {
            SpawnEnemy();
            spawnAmount += 2;
            spawnTimeCounter = spawnTime;

        }
    }

    public void SpawnEnemy()
    {
        for(int i = 0; i < spawnAmount; i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x /2), Random.Range(-size.y / 2, size.y / 2), 0f);
            Instantiate(enemy , pos, Quaternion.identity);
        }
        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(center, size);
    }
}
