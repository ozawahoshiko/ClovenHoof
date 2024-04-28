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
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    public void bookFlipsound()
    {
        audioSource.PlayOneShot(bookfl);
    }
}
