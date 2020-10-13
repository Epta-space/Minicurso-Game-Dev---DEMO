using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 10;
    private float jumpForce = 3;
    private int cont;

    private int currentDirection; //1 = right; -1 = left;
    private bool moving;

    public Animator animator;

    void Start(){
        moving = false;
        currentDirection = 1;
        rb = GetComponent<Rigidbody2D>();
        cont = 0;
    }

    void Update(){

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 dir = new Vector2(x,y);
        

        if (Input.GetKeyDown(KeyCode.Space)&& cont<=0){
            jump();
            cont++;
        }

        walk(dir);

        animator.SetFloat("Animator_speed", dir.x);

        if(moving){
            rb.velocity = (new Vector2(currentDirection * speed, rb.velocity.y));
        }
    }

    public void HorizontalMove(int direction){
        moving = true;
        if(currentDirection < 0 && direction > 0){
            currentDirection = 1;
            this.transform.rotation = new Quaternion(0,0,0,0);
        } else if(currentDirection > 0 && direction < 0){
            currentDirection = -1;
            this.transform.rotation = new Quaternion(0,180,0,0);
        }
        animator.SetFloat("Animator_speed", currentDirection);
    }

    public void HorizontalStay(){
        moving = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        cont =0;
    }

    public void walk(Vector2 dir){
        if(dir.x < 0){
            this.transform.rotation = new Quaternion(0,180,0,0);
        }else{
            this.transform.rotation = new Quaternion(0,0,0,0);
        }
        rb.velocity = (new Vector2(dir.x * speed, rb.velocity.y));
        animator.SetFloat("Animator_speed", dir.x);
    }

    public void jump(){
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += Vector2.up * jumpForce;
    }
}
