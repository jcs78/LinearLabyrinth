using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objsPlayer = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] objsRedSKF = GameObject.FindGameObjectsWithTag("SKF (Red)");
        GameObject[] objsBlueSKF = GameObject.FindGameObjectsWithTag("SKF (Blue)");

        if (objsPlayer.Length > 1)
        {
            Destroy(this.gameObject);
        }
        if (objsRedSKF.Length > 1)
        {
            Destroy(this.gameObject);
        }
        if (objsBlueSKF.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
