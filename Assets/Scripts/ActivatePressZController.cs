using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivatePressZController : MonoBehaviour
{
    public GameObject pressZ;
    public GameObject creditsMap;
    private bool lever = false;
    private bool leverCredits = false;
    private int counter = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        pressZ.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!lever)
        {
            pressZ.SetActive(true);
            lever = true;
        }

        if (leverCredits && Input.GetKey("x"))
        {
            leverCredits = false;
        }
        else if (!leverCredits)
        {
            if (Input.GetKey("right") && !(counter == 3))
            {
                counter += 1;
            }
            else if (Input.GetKey("left") && !(counter == 1))
            {
                counter -= 1;
            }

            if (Input.GetKey("z"))
            {
                switch (counter)
                {
                    case 1:
                        SceneManager.LoadScene("Hub");
                        break;
                    case 2:
                        leverCredits = true;
                        creditsMap.SetActive(true);
                        break;
                    case 3:
                        SceneManager.LoadScene("TitleScreen");
                        break;
                    default:
                        Debug.Log("Save me.");
                        break;
                }
            }
        }
    }
}
