using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchSound : MonoBehaviour
{

    public AudioClip switchsound;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    public void SwitchSound()
    {
        audioSource.PlayOneShot(switchsound);
    }

}
