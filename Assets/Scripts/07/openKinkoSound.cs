using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openKinkoSound : MonoBehaviour
{
    public AudioClip kinkoSource;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    public void kinkoSound()
    {
        audioSource.PlayOneShot(kinkoSource);
    }
}
