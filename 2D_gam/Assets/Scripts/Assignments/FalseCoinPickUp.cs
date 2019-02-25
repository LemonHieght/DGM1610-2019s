using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseCoinPickUp : BasicPickUp
{
    public GameObject PC;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "PC")
        {
            //colect coin
        }
        else
        {
            // not player
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
