using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    private float attackTime = .25f;
    private float attackCounter = .25f;
    private bool isAttacking;
    private HealthManager healthMan;

    Vector2 movement;
     

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(Input.GetAxisRaw("Horizontal")==1 || Input.GetAxisRaw("Horizontal")==-1 || Input.GetAxisRaw("Vertical")==1 || Input.GetAxisRaw("Vertical")==-1)
        {
            animator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
        if(isAttacking)
        {
             
            attackCounter -= Time.deltaTime;
            if(attackCounter<=0)
            {
                animator.SetBool("isAttacking", false);
                isAttacking = false;
            }
        }
        if(Input.GetKeyDown(KeyCode.M))
        {
                attackCounter = attackTime;
               animator.SetBool("isAttacking", true);
                isAttacking = true;
        }

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -22.7f, 19.2f),
                                        Mathf.Clamp(transform.position.y, -9.13f, 9.7f));
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
	 
    
}
