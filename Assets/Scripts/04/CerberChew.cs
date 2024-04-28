using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class CerberChew : MonoBehaviour
{

    public AudioClip chew;
    AudioSource audioSource;

   

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();

    }


    public void Chew()
    {
        audioSource.PlayOneShot(chew);
    }

    
}
