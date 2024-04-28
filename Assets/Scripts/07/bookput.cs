using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookput : MonoBehaviour
{
    public AudioClip bookpu;
    AudioSource audioSource;

    public static bookput instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    public void bookclosesound()
    {
        audioSource.PlayOneShot(bookpu);
    }
}
