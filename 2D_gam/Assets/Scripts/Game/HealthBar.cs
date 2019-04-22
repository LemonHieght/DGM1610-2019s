using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider health;
    public Text healthCount;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health.maxValue = playerHealth.playerMaxHealth;
        health.value = playerHealth.playerCurrentHealth;
        healthCount.text = "Health: " + playerHealth.playerCurrentHealth;
    }
}
