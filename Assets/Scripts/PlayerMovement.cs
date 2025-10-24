using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 200f;
    public float LeftOrRight = 500f;

    // fixed update used when applying physics to the game
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime); //time.deltatime used to maintain force effectivity across different PCs(FPS)

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(LeftOrRight * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-LeftOrRight * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if(rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
