using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleman : MonoBehaviour
{
    
    public AudioClip ladysand;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    public void invisiTalk()
    {
        audioSource.PlayOneShot(ladysand);
    }
}
