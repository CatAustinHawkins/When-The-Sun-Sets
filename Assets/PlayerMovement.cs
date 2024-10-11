using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float jump;
    public Rigidbody2D rb;
    public bool isGrounded;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jump);
        }

        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = Vector2.left * speed;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = Vector2.right * speed;
        }
        */
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
