using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirrorSound : MonoBehaviour
{
    public AudioClip kin;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void mirrorsound()
    {
        audioSource.PlayOneShot(kin);
    }
}

