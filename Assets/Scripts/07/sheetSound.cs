using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheetSound : MonoBehaviour
{
    public AudioClip sheet;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    public void sheetsound()
    {
        audioSource.PlayOneShot(sheet);
    }
}

