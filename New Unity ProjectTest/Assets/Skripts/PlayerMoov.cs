using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoov : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 2f;
    public float jampForse = 250f;
    public bool onGraund;
    public Transform GraundChek;
    public float chekRadius = 0.5f;
    public LayerMask Ground;






    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }





    void Update()
    {
        walk();
        jamp();
        CheckingGround();
    }






    void walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
         rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
       // rb.AddForce(moveVector * speed);
    }


    void jamp()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGraund)
        {
            // rb.velocity = new Vector2(rb.velocity.x, jampForse);
            rb.AddForce(Vector2.up * jampForse);
        }
    }


    void CheckingGround()
    {
        onGraund = Physics2D.OverlapCircle(GraundChek.position, chekRadius, Ground);
    }

}
