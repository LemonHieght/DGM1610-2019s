using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int playerMaxHealth;
    public int playerCurrentHealth;
    public SpawnArea spawnArea;
    public WaveReward waveReward;

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
            SceneManager.LoadScene(0);

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
