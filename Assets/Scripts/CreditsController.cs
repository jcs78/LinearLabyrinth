using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsController : MonoBehaviour
{
    public GameObject pressZ;
    
    // Start is called before the first frame update
    void Start()
    {
        pressZ.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         if (Input.GetKey("x"))
         {
             pressZ.SetActive(true);
             gameObject.SetActive(false);
         }
    }
}
