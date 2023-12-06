/* Character Movement in the Up, Down, Left, and Right direction. */
/* Team: Itzy Bitz, Member: Anthony Bermudez*/ 
/* Date: 09/24/2022 @3:37 p.m. */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; /* Defaulted move speed to "5". */

    public Rigidbody2D rb; /* Component that moves our player. */

    Vector2 movement; // Will store an X and a Y.


    // Update is called once per frame
    void Update() // This will handle the input.
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // Function will return -1 when wanting to move left, +1 when moving right. Doing nothing returns 0.
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() // This will handle the movement of our character. Executed on a fixed timer, unlike Update().
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); // Will move the rigidbody to a new position, will collide with anything
                                                                                   // in the way, and retain a fixed speed of movement.


    }
}











