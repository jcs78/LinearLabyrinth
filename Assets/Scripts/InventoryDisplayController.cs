﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplayController : MonoBehaviour
{
    public GameObject partyMem1;

    private Vector3 offset;

    // Start is called before the first frame update.
    void Start()
    {
        offset = transform.position - partyMem1.transform.position;
    }

    // LateUpdate is called once per frame, but is guarenteed to run after all items have been processed in Update.
    void LateUpdate()
    {
        transform.position = partyMem1.transform.position + offset;
    }
}
