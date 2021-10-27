using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -22.7f, 19.0f),
                                        Mathf.Clamp(transform.position.y, -9.13f, 9.7f));
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
	 private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("obstacol"))
        {
            col.gameObject.SetActive(false);
        }
    }
}
