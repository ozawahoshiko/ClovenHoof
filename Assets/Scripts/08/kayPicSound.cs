using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayPicSound : MonoBehaviour
{
    public AudioClip keypic;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    public void keypicsound()
    {
        audioSource.PlayOneShot(keypic);
    }
}
