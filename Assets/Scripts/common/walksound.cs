using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walksound : MonoBehaviour
{

    public AudioClip walk;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void Walksound()
    {
        audioSource.PlayOneShot(walk);

    }
}
