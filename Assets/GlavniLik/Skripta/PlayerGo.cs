using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGo : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public Animator animator;
    public Transform body;

    bool right = false;
    bool wakling=false;
    void Start()
    {

    }


    void Update()
    {
        ProccessInputs();
    }

    private void FixedUpdate()
    {
        Move();
    }
    float x_scale = 0;

    void ProccessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        if (moveX > 0)
        {
            if (wakling == true && right == false)
            {
                animator.Play("OkretL");
            }
            else
            {
                animator.Play("WAlk");
            }
        }

        if (moveX < 0)
        {
            if (wakling == true && right == true)
            {
                animator.Play("OkretL");
            }
            else
            {
                animator.Play("WAlk");
            }
        }
        if (moveX != 0 || moveY != 0)
        {
            if (moveX != 0)
                transform.localScale = new Vector3(-moveX, transform.localScale.y, transform.localScale.z);
            if (moveX == 0 && moveY != 0)
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
                animator.Play("WAlk");
            }
            wakling = true;
        }
        else
        {
            if (x_scale < 0)
            {
                right = true;
            }

            if (x_scale > 0)
            {
                right = false;
            }
            animator.Play("Idle");
            wakling = false;
        }
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    
}
