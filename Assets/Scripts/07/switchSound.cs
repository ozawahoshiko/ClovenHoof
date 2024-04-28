using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchSound : MonoBehaviour
{

    public AudioClip switchsound;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    public void SwitchSound()
    {
        audioSource.PlayOneShot(switchsound);
    }

}
