using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePressZController : MonoBehaviour
{
    public GameObject pressZ;
    
    // Start is called before the first frame update
    void Start()
    {
        pressZ.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pressZ.SetActive(true);
    }
}
