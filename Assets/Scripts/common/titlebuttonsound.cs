using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlebuttonsound : MonoBehaviour
{
    public AudioClip buttonsounds;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    public void TitleButtonSound()
    {
        audioSource.PlayOneShot(buttonsounds);
    }
}
