using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector2 movement;
    private RaycastHit2D hit;
    private Animator animator;

    // Start is called before the first frame update
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    //  Start up animation
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Player movement
    private void OnMovement (InputValue value)
    {
        movement = value.Get<Vector2>();

        if(movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }

    // player Jump
    private void OnJump()
    {
        Debug.Log("Jumped");
        //animator.SetBool("JumpingRight", true);
    }

    private void FixedUpdate()
    {
        // double check we can move in direction, by casting a box there first . if box returns null then move
        hit = Physics2D.BoxCast(transform.position,boxCollider.size, 0, new Vector2(0,movement.y),Mathf.Abs(movement.y * Time.deltaTime), LayerMask.GetMask("Player","Blocking"));
        if(hit.collider == null)
        {
            transform.Translate(0,movement.y * Time.deltaTime, 0);
        }
        hit = Physics2D.BoxCast(transform.position,boxCollider.size, 0, new Vector2(movement.x,0),Mathf.Abs(movement.x * Time.deltaTime), LayerMask.GetMask("Player","Blocking"));
        if(hit.collider == null)
        {
            transform.Translate(movement.x * Time.deltaTime, 0,0);
        }
    }
}
