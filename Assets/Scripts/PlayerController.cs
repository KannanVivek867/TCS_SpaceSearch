using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed;
    private Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;
    public BlackHole blackHole;
    // Start is called before the first frame update
    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    public void Update()
    { 
        PlayerMovement();
        PlayerFlip();
    }

    public void PlayerMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
       rb2d.velocity = new Vector2(moveHorizontal * speed , rb2d.velocity.y);

    }

    public void PlayerFlip()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
           // spriteRenderer.transform.localScale = new Vector3(-180, 0, 0);
           spriteRenderer.flipX = true;
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            spriteRenderer.flipX = false;
            //spriteRenderer.transform.localScale = new Vector3(180, 0, 0);
        }
    }
     public void PlayerShrink()
    {
     transform.localScale -= new Vector3(0.0001f, 0.0001f, 0.0001f);
    }
}