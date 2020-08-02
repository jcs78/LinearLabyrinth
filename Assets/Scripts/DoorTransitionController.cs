using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTransitionController : MonoBehaviour
{
    public float x_position;
    public float y_position;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKey("z"))
        {
            other.gameObject.transform.position = new Vector2(x_position, (y_position - 0.25f));
        }
    }
}
