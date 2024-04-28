using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picSound : MonoBehaviour
{
    public AudioClip pic;
    AudioSource audioSource;
    public static picSound instance;

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
    public void picsound()
    {
        audioSource.PlayOneShot(pic);
    }
}
