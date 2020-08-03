﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;

    private Rigidbody2D rb2d;
    private float moveHorizontal;

    public GameObject mountainClimber;
    public GameObject camera1;
    public GameObject camera2;
    
    private int redLeft = 4;
    private int blueLeft = 6;
    
    public Text fragmentsLeft;
    
    public GameObject ceAbilityIcon;
    public GameObject mcAbilityIcon;

    public GameObject redIcon;
    public GameObject blueIcon;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.constraints = RigidbodyConstraints2D.None;
        fragmentsLeft.text = redLeft.ToString();
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

        if (Input.GetKey("right shift"))
        {
            mountainClimber.SetActive(true);
            mountainClimber.transform.position = new Vector2(transform.position.x, transform.position.y);
            camera2.SetActive(true);
            camera2.transform.position = new Vector3(camera1.transform.position.x, camera1.transform.position.y, -10.0f);
            mcAbilityIcon.SetActive(true);

            camera1.SetActive(false);
            ceAbilityIcon.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("SKF (Red)"))
        {
            other.gameObject.SetActive(false);
            redLeft -= 1;
            
        }
        else if (other.gameObject.CompareTag("SKF (Blue)"))
        {
            other.gameObject.SetActive(false);
            blueLeft -= 1;
        }
        
        if (redLeft < 1)
        {
            redIcon.gameObject.SetActive(false);
            blueIcon.gameObject.SetActive(true);
            fragmentsLeft.text = blueLeft.ToString();
        }
        else
        {
            fragmentsLeft.text = redLeft.ToString();
        }
    }
}
