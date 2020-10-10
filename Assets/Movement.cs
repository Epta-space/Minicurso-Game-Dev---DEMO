using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10;
    private float jumpForce = 3;
    private int cont;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        cont = 0;
    }

    void Update(){
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(x,y);
        if (Input.GetKeyDown(KeyCode.Space) && cont<=1)
        {
            jump();
            cont++;
        }
        walk(dir);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        cont =0;
    }

    private void walk(Vector2 dir){
        rb.velocity = (new Vector2(dir.x * speed, rb.velocity.y));
    }

    private void jump(){
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += Vector2.up * jumpForce;
    }
}
