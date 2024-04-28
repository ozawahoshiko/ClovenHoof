using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardbordsound : MonoBehaviour
{
    public AudioClip cbsound;
    AudioSource audioSource;
    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void CBsound()
    {
        audioSource.PlayOneShot(cbsound);

    }
}
