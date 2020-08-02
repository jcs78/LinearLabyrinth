using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOpt : MonoBehaviour
{
    private int counter = -1;

    void FixedUpdate()
    {
        if (Input.GetKey("right") && (counter == -1))
        {
            transform.position = new Vector2(-0.1f, -1.5f);
            counter += 1;
            Debug.Log("Right -1 Activated");
        }
        else if (Input.GetKey("right") && (counter == 0))
        {
            transform.position = new Vector2(3.85f, -1.5f);
            counter += 1;
            Debug.Log("Right 0 Activated");
        }
        else if (Input.GetKey("left") && (counter == 1))
        {
            transform.position = new Vector2(-0.1f, -1.5f);
            counter -= 1;
            Debug.Log("Left 1 Activated");
        }
        else if (Input.GetKey("left") && (counter == 0))
        {
            transform.position = new Vector2(-4.0f, -1.5f);
            counter -= 1;
            Debug.Log("Left 0 Activated");
        }
    }
}
