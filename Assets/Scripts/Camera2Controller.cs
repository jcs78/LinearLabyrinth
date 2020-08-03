using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2Controller : MonoBehaviour
{
    public GameObject partyMem2;

    private Vector3 offset;

    // Start is called before the first frame update.
    void Start()
    {
        offset = transform.position - partyMem2.transform.position;
    }

    // LateUpdate is called once per frame, but is guarenteed to run after all items have been processed in Update.
    void LateUpdate()
    {
        transform.position = partyMem2.transform.position + offset;
    }
}
