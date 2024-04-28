using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotlightSound : MonoBehaviour
{
    public AudioClip spot;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void spotlightsound()
    {
        audioSource.PlayOneShot(spot);
    }
}
