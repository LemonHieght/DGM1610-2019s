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
        
            if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                // transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
                myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidbody.velocity.y);
                playerMove = true;
                lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f).normalized;

            }
        
            if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            {
                // transform.Translate ( new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
                playerMove = true;
                lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical")).normalized;

            }
        
            //To stop ice skate sliding

            if(Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
            {
                myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
            }
            if(Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);
            }


        //Attack

        }
        if(Input.GetKeyDown(KeyCode.F))
        {

            attackTimeCounter = attackTime;
            attack = true;
            myRigidbody.velocity = Vector2.zero;
            anim.SetBool("Attack", true);

            //Attack Colliders

            if(dir == "right")
            {
                rightAttack.SetActive(true);
            }
            else if(dir == "left")
            {
                leftAttack.SetActive(true);
            } else if(dir == "up")
            {
                upAttack.SetActive(true);
            }
            else if(dir == "down")
            {
                downAttack.SetActive(true);
            }

        }
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

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("Moving", playerMove);
        anim.SetFloat("LastX", lastMove.x);
        anim.SetFloat("LastY", lastMove.y);
    }
}
