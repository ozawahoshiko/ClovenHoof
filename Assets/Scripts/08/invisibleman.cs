using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleman : MonoBehaviour
{
    
    public AudioClip ladysand;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    public void invisiTalk()
    {
        audioSource.PlayOneShot(ladysand);
    }
}
