using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //player movement varables
   public float moveSpeed;
   public float jumpHeight;
   //player grounded variables
   private bool grounded = true;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
        // this && that
        // this || (or) that
        // ++ increase
        // -- decrease
        // == is equal
        // = are/set equal
        // ! not this


    // Update is called once per frame
    void Update() 
    {
        //player movement left and right
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y); 
        }
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y); 
        }
        //player movement up  and down
        if(Input.GetKeyDown(KeyCode.W) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }
        if(Input.GetKeyDown(KeyCode.S) && !grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -jumpHeight);
        }
    
    }
}
