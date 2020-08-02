using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightChoiceController : MonoBehaviour
{
    private int counter = -1;

    void FixedUpdate()
    {
        if (Input.GetKey("right"))
        {
            if (counter == -1)
            {
                transform.position = new Vector2(-0.1f, -1.5f);
                counter += 1;
            }
            else if (counter == 0)
            {
                transform.position = new Vector2(3.85f, -1.5f);
                counter += 1;
            }
        }
        else if (Input.GetKey("left"))
        {
            if (counter == 1)
            {
                transform.position = new Vector2(-0.1f, -1.5f);
                counter -= 1;
            }
            else if (counter == 0)
            {
                transform.position = new Vector2(-4.0f, -1.5f);
                counter -= 1;
            }
        }
    }
}
