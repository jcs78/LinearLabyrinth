using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionController : MonoBehaviour
{
    public string levelName;

    void Update()
    {
        if (Input.GetKey("z"))
        {
            SceneManager.LoadScene(levelName);
        }
        else if (Input.GetKey("escape"))
        {
            Debug.Log("Escape was pressed!");
            Application.Quit();
        }
    }
}
