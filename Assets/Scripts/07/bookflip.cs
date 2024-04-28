using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookflip : MonoBehaviour
{
    public AudioClip bookfl;
    AudioSource audioSource;

    public static bookflip instance;

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

    public void bookFlipsound()
    {
        audioSource.PlayOneShot(bookfl);
    }
}
