using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float walkSpeed;
    private Rigidbody2D myRigidbody;
    private Animator anim;
    private bool playerMove;
    private Vector2 lastMove;
    private bool attack;
    public float attackTime;
    private float attackTimeCounter;
    public GameObject leftAttack;
    public GameObject rightAttack;
    public GameObject upAttack;
    public GameObject downAttack;
    public string dir = "down";

    public Joystick joyCon;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        playerMove = false;
        if(!attack)
        {
            
            //walking and movement
        
            if(joyCon.Horizontal > 0.1f)
            {
                myRigidbody.velocity = new Vector2( moveSpeed, myRigidbody.velocity.y);
                playerMove = true;
                lastMove = new Vector2(1f, 0f).normalized;
            }
            else if (joyCon.Horizontal < -0.1f)
            {
                myRigidbody.velocity = new Vector2( -moveSpeed, myRigidbody.velocity.y);
                playerMove = true;
                lastMove = new Vector2(-1f, 0f).normalized;
            }
            else
            {
                myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
            }
        
            if(joyCon.Vertical > 0.1f)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, moveSpeed);
                playerMove = true;
                lastMove = new Vector2(0f, 1f).normalized;
            }
            else if (joyCon.Vertical < -0.1f)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, -moveSpeed);
                playerMove = true;
                lastMove = new Vector2(0f, -1f).normalized;
            }
            else
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
            }


            //Attack

        }
        // if(Input.GetKeyDown(KeyCode.F))
        // {
        //
        //     attackTimeCounter = attackTime;
        //     attack = true;
        //     myRigidbody.velocity = Vector2.zero;
        //     anim.SetBool("Attack", true);
        //
        //     //Attack Colliders
        //
        //     if(dir == "right")
        //     {
        //         rightAttack.SetActive(true);
        //     }
        //     else if(dir == "left")
        //     {
        //         leftAttack.SetActive(true);
        //     } else if(dir == "up")
        //     {
        //         upAttack.SetActive(true);
        //     }
        //     else if(dir == "down")
        //     {
        //         downAttack.SetActive(true);
        //     }
        //
        // }
        if(attackTimeCounter > 0)
        {
            
            attackTimeCounter -= Time.deltaTime;

        }
        
        if(attackTimeCounter <= 0)
        {

            attack = false;
            anim.SetBool("Attack", false);
            downAttack.SetActive(false);
            upAttack.SetActive(false);
            leftAttack.SetActive(false);
            rightAttack.SetActive(false);
        }
        
        if(lastMove ==Vector2.left)
            {
                dir = "left";
            }
            else if(lastMove == Vector2.right)
            {
                dir = "right";
            }
            else if(lastMove == Vector2.up)
            {
                dir = "up";
            }
            else if(lastMove == Vector2.down)
            {
                dir = "down";
            }

        //Animation transition

        anim.SetFloat("MoveX", joyCon.Horizontal);
        anim.SetFloat("MoveY", joyCon.Vertical);
        anim.SetBool("Moving", playerMove);
        anim.SetFloat("LastX", lastMove.x);
        anim.SetFloat("LastY", lastMove.y);
    }

    public void Attack()
    {
        if (attack == false)
        {
            attackTimeCounter = attackTime;
            attack = true;
            myRigidbody.velocity = Vector2.zero;
            anim.SetBool("Attack", true);

            if (dir == "right")
            {
                rightAttack.SetActive(true);
            }
            else if (dir == "left")
            {
                leftAttack.SetActive(true);
            }
            else if (dir == "up")
            {
                upAttack.SetActive(true);
            }
            else if (dir == "down")
            {
                downAttack.SetActive(true);
            }
        }
    }
}
