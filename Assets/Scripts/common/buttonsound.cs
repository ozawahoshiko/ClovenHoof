using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsound : MonoBehaviour
{
    public AudioClip buttonsounds;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    public void ButtonSound()
    {
        audioSource.PlayOneShot(buttonsounds);
    }
    /*public void TitleButtonSound()
    {
        audioSource.PlayOneShot(buttonsounds3);
    }*/
}
