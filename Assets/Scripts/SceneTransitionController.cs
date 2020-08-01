using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionController : MonoBehaviour
{
    public string levelName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("z"))
        {
            SceneManager.LoadScene(levelName);
            Debug.Log("Everything's Peachy");
        }
    }
}
