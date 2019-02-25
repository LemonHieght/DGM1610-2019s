using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueCoinPickUp : MonoBehaviour
{
    public int coinValue;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            print("YOU STOLE MY MONEY!");
           
            Destroy(gameObject);
        }
    }
}
