using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pakaSound : MonoBehaviour
{

    public AudioClip paka;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void pakasound()
    {
        audioSource.PlayOneShot(paka);
    }
}
