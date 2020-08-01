using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeController : MonoBehaviour
{
    public string levelName;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKey("z"))
        {
            SceneManager.LoadScene(levelName);
            Debug.Log("Everything's Peachy");
        }
    }
}
