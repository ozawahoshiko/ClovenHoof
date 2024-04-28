using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchSound : MonoBehaviour
{
    public AudioClip fire;
    AudioSource audioSource;
    public static matchSound instance;

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
    // Start is called before the first frame update
    public void matchsound()
    {
        audioSource.PlayOneShot(fire);
    }
}
