using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int playerMaxHealth;
    public int playerCurrentHealth;
    public SpawnArea spawnArea;

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnArea.liveEnemys <= 0)
        {
            playerCurrentHealth = playerMaxHealth;
        }
        
        if(playerCurrentHealth <= 0f)
        {
            
            gameObject.SetActive(false);

        }
    }
    public void HurtPlayer(int damageToGive)
    {

        playerCurrentHealth -= damageToGive;
    }

    public void SetMaxHeath()
    {
        playerMaxHealth = playerCurrentHealth;
    }
}
