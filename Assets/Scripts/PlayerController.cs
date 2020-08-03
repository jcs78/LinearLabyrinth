using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;

    private Rigidbody2D rb2d;
    private float moveHorizontal;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.constraints = RigidbodyConstraints2D.None;
    }

    void FixedUpdate()
    {
        rb2d.constraints = RigidbodyConstraints2D.None;
        moveHorizontal = Input.GetAxis("Horizontal");
        animator.SetFloat("Movement", moveHorizontal);
        Vector2 movement = new Vector2 (moveHorizontal, 0);
        rb2d.AddForce(movement * speed);

        if (!Input.anyKey)
        {
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("SKF"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
