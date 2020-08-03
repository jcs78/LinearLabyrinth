using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainClimberController : MonoBehaviour
{
    public Animator animator;
    public float speed;

    private Rigidbody2D rb2d;
    private float moveHorizontal;

    public GameObject caveExplorer;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject inventoryHud1;
    public GameObject inventoryHud2;

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
            inventoryHud1.SetActive(true);
            inventoryHud1.transform.position = new Vector2(inventoryHud2.transform.position.x, inventoryHud2.transform.position.y);

            camera2.SetActive(false);
            inventoryHud2.SetActive(false);
            gameObject.SetActive(false);
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