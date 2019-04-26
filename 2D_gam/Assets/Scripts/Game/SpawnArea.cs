using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour
{
    public int spawnAmount = 1;
    public float waitTime;
    public float waitTimeCounter;
    public GameObject enemy;
    public Vector3 center;
    public Vector3 size; 
    public int liveEnemys;
    public bool nextWave;
    public int waveCounter;
    public WaveReward waveReward;
    public GameObject soul;
    public bool soulSpawn;


    // Start is called before the first frame update
    void Start()
    {
        waitTime = 100;
        nextWave = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(waveCounter == 5 ||waveCounter == 10 || waveCounter == 15 || waveCounter == 20)
        {
            if(nextWave&& !soulSpawn)
            {
                SpawnSoul();
                soulSpawn = true;
            }
        }

        if(waitTimeCounter > 0)
        {
            waitTimeCounter -= Time.deltaTime;
        }
        if(waitTimeCounter <= 0)
        {
            SpawnEnemy();
            spawnAmount++;
            waitTimeCounter = waitTime;
            nextWave = false;
            
        }
        if(liveEnemys <= 0 && !nextWave)
            {
                waitTimeCounter = 5;
                nextWave = true;
                waveCounter++;
                soulSpawn = false;

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
    public void SpawnSoul()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x /2), Random.Range(-size.y / 2, size.y / 2), 0f);
        Instantiate(soul , pos, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireCube(center, size);
    }
}
