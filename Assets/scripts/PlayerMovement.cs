using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //public int health = 100;
    public float speed = 4.5f;
    public float jumpForce = 5;
    public string hero = "Peter";
    // public bool isAlive = true;

    public Vector3 direction;
    public Rigidbody playerRb;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is" + hero);


    }

    // Update is called once per frame using void update 
    void FixedUpdate()
    ///improves physics functionality,50 times per frame 
    {
        //transform.Translate(direction * Time.deltaTime * speed);
        //the dot is there to access a functionality of transform
        Vector3 velocity = direction * speed;
        velocity.y = playerRb.linearVelocity.y;

        playerRb.linearVelocity = velocity;

    }

    private void OnMove(InputValue value)
    {
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(
            inputValue.x,
            0,
            inputValue.y
            );
        //asks the inoput system what keys are being pressed

        Debug.Log("My name is" + hero);

    }

private void OnJump( InputValue value) 
    {
        bool isGrounded = Physics.Raycast(transform.position,Vector3.down, 1f);
        if (isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // physics raycast will cast aline that can hit other colliders , if it finds a collider, it returns true, if not , it returns false 
        }
    }
}
