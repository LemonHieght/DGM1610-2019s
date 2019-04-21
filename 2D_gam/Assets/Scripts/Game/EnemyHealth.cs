using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
public int maxHealth;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(currentHealth <= 0f)
        {
            
            Destroy (gameObject);

        }
    }
    public void HurtEnemy(int damageToGive)
    {

        currentHealth -= damageToGive;
    }

    public void SetMaxHeath()
    {
        maxHealth = currentHealth;
    }
}
