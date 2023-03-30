using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotcontroler : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer sr;
    private int currentAnimation = 1;

    void Start()
    {
        animator = GetComponent<Animator>(); 
       rb = GetComponent<Rigidbody2D>(); 
       sr = GetComponent<SpriteRenderer>(); 
    }

    void Update()
    {
        currentAnimation = 1;
        var velocityY = rb.velocity.y;
        rb.velocity = new Vector2(0, velocityY);

        if(Input.GetKey(KeyCode.RightArrow))
        {
            currentAnimation = 2;
            rb.velocity = new Vector2(5,velocityY);
            sr.flipX = false;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            currentAnimation = 2;
            rb.velocity = new Vector2(-5,velocityY);
            sr.flipX = true;
        }
         if(Input.GetKey(KeyCode.W))
        {
            currentAnimation = 3;
        }
        if(Input.GetKey(KeyCode.A))
        {
            currentAnimation = 4;
            rb.velocity = new Vector2(5,velocityY);
            sr.flipX = false;
        }
        if(Input.GetKey(KeyCode.Z))
        {
            currentAnimation = 5;
        }
        if(Input.GetKey(KeyCode.C))
        {
            currentAnimation = 6;
            rb.velocity = new Vector2(-5,velocityY);
        }
        if(Input.GetKey(KeyCode.V))
        {
            currentAnimation = 6;
            rb.velocity = new Vector2(10,velocityY);
        }
        if(Input.GetKey(KeyCode.D))
        {
            currentAnimation = 7;
        }

        animator.SetInteger("Estado",currentAnimation);
    }
}
