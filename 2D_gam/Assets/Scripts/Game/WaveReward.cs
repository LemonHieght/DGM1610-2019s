using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveReward : MonoBehaviour
{
    public GameObject player;
    public SpawnArea spawnArea;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D player)
    {
        playerHealth.playerMaxHealth += 20;
        playerHealth.playerCurrentHealth += 20;

        Destroy(gameObject);
        
    }
}
