using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Animator animator;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("Movement", moveHorizontal);
        
        Vector2 movement = new Vector2 (moveHorizontal, 0);
        rb2d.AddForce(movement * speed);
    }
}
