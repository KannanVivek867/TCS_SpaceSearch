using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public bool isGrounded;
    public Transform groundCheck;
    public float circleRadius;
    public LayerMask ground;
    public float jumpForce;
    private float jumpTimer;
    public float jumpTimerValue;
    private bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        rb2D =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    public void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, circleRadius, ground);

        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimer = jumpTimerValue;
            rb2D.velocity = Vector2.up * jumpForce;
        }
        if(Input.GetKey(KeyCode.Space) && isJumping == true){
            if(jumpTimer > 0)
            {
                rb2D.velocity = Vector2.up * jumpForce;
                jumpTimer -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }
}
