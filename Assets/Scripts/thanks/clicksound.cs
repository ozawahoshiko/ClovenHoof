using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicksound : MonoBehaviour
{
    public AudioClip click;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    public void clickSound()
    {
        audioSource.Play();
    }
}
