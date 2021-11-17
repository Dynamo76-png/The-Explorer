using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Public Variables
    public float forceStrengh;

    public void Update()
    {
        // Get the rigidbody from our player so we can check its speed
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // Find out from the rigidbody what our current horizontal and vertical speeds are
        float currentSpeedH = ourRigidbody.velocity.x;
        float currentSpeedV = ourRigidbody.velocity.y;

        // Get the animator that we'll be using for movement
        Animator ourAnimator = GetComponent<Animator>();

        // Tell our animator what the speeds are
        ourAnimator.SetFloat("SpeedH", Mathf.Abs(currentSpeedH));
        if (currentSpeedH != 0)
        {
            SpriteRenderer ourSpriter = GetComponent<SpriteRenderer>();
            ourSpriter.flipX = currentSpeedH < 0;
        }    
        ourAnimator.SetFloat("SpeedV", currentSpeedV);

        // Check if the player is pressing a key
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }
        if (Input.GetKey(KeyCode.W))
        {
            Jump();
        }
    }

    public void Jump()
    {

    }
    public void MoveRight()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.AddForce(Vector2.right * forceStrengh);
    }


    public void MoveLeft()
    {
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.AddForce(Vector2.left * forceStrengh);
    }

}