using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeController : MonoBehaviour
{
    public string tagName;
    public string levelName;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(tagName) && Input.GetKey("z"))
        {
            SceneManager.LoadScene(levelName);
            Debug.Log("Everything's Peachy");
        }
    }
}
