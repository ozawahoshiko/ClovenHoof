using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicSound : MonoBehaviour
{

    public AudioClip magic;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void magicsound()
    {
        audioSource.PlayOneShot(magic);
    }
}
