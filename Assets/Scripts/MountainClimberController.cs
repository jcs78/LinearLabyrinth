using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MountainClimberController : MonoBehaviour
{
    public Animator animator;
    public float speed;

    private Rigidbody2D rb2d;
    private float moveHorizontal;

    public GameObject caveExplorer;
    public GameObject camera1;
    public GameObject camera2;

    private bool abilityLever = false;

    public GameObject ceAbilityIcon;
    public GameObject mcAbilityIcon;

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
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb2d.AddForce(movement * speed);

        if (!Input.anyKey)
        {
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionX;
        }

        if (Input.GetKey("left shift"))
        {
            caveExplorer.SetActive(true);
            caveExplorer.transform.position = new Vector2(transform.position.x, transform.position.y);
            camera1.SetActive(true);
            camera1.transform.position = new Vector3(camera2.transform.position.x, camera2.transform.position.y, -10.0f);
            ceAbilityIcon.SetActive(true);

            camera2.SetActive(false);
            mcAbilityIcon.SetActive(false);
            gameObject.SetActive(false);
        }
    }
 
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Climbable Wall") && Input.GetKey("x"))
        {
            if (!abilityLever)
            {
                gameObject.transform.position = other.gameObject.transform.position + new Vector3(3.00f, 4.00f, 0.00f);
                abilityLever = true;
            }
            else
            {
                gameObject.transform.position = other.gameObject.transform.position + new Vector3(-3.00f, 0.00f, 0.00f);
                abilityLever = false;
            }
        }
    }
}