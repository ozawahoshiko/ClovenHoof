using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookpickSound : MonoBehaviour
{
    public AudioClip book;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }
    
    public void bookPicsound()
    {
        audioSource.PlayOneShot(book);
    } 

}
