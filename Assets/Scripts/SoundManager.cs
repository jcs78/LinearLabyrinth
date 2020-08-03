using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip obtainKeyFragment;
    static AudioSource audioSrc;
    
    // Start is called before the first frame update
    void Start()
    {
        obtainKeyFragment = Resources.Load<AudioClip>("jingles_STEEL15");
        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jingles_STEEL15":
                audioSrc.PlayOneShot(obtainKeyFragment);
                break;
        }
    }
}
