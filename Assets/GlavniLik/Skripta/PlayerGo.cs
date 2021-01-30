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
    bool wakling = false;
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
            
            gameObject.transform.GetChild(0).transform.rotation = Quaternion.Lerp(Quaternion.Euler(new Vector3(0, 180, 0)), Quaternion.Euler(new Vector3(0, 0, 0)), 0.1f * Time.deltaTime);
            if (wakling == true && right == false)
            {
                animator.Play("WAlk");
            }
            else
            {
                animator.Play("WAlk");
            }

        }

        if (moveX < 0)
        {
            
            gameObject.transform.GetChild(0).transform.rotation = Quaternion.Lerp(Quaternion.Euler(new Vector3(0, 0, 0)), Quaternion.Euler(new Vector3(0, 180, 0)), 0.1f * Time.deltaTime);
            if (wakling == true && right == true)
            {
                animator.Play("WAlk");
            }
            else
            {
                animator.Play("WAlk");
            }

        }
        if (moveX != 0 || moveY != 0)
        {
            animator.Play("WAlk");
            if (moveX != 0)
                //transform.localScale = new Vector3(-moveX, transform.localScale.y, transform.localScale.z);
            if (moveX == 0 && moveY != 0)
            {
                //transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
                
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
