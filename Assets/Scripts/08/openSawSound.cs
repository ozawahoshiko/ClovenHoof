using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSawSound : MonoBehaviour
{
    public AudioClip opensaw;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    public void Sawsound()
    {
        audioSource.PlayOneShot(opensaw);
    }
}
