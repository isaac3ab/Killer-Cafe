using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCharacterMovement : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveRight;
    public KeyCode moveLeft;
    public Rigidbody2D mainCharacter;
    public float movementSpeed;
    public float yborder;
    public float xborder;


    void Start()
    {
        mainCharacter = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //assigns a velocity to the main character
        Vector2 velocity = mainCharacter.velocity;

        //checks if the main character is within the boundaries and the button is clicked then moves it accordingly
        if (Input.GetKey(moveUp) && mainCharacter.transform.position.y < yborder)
        {
            velocity.y = movementSpeed;
        }
        else if (Input.GetKey(moveDown) && mainCharacter.transform.position.y > -yborder)
        {
            velocity.y = -movementSpeed;
        }
        else
        {
            velocity.y = 0;
        }

        if (Input.GetKey(moveRight) && mainCharacter.transform.position.x < xborder)
        {
            velocity.x = movementSpeed;
        }
        else if (Input.GetKey(moveLeft) && mainCharacter.transform.position.x > -xborder)
        {
            velocity.x = -movementSpeed;
        }
        else
        {
            velocity.x = 0;
        }
        //if up and down or left and right are both pressed it won't move either
        if (Input.GetKey(moveDown) && Input.GetKey(moveUp))
        {
            velocity.y = 0;
        }

        if (Input.GetKey(moveRight) && Input.GetKey(moveLeft))
        {
            velocity.x = 0;
        }
        //sets the velocity equal to the velocity you created in the if statements
        mainCharacter.velocity = velocity;
    }
}


