using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kitchensound : MonoBehaviour
{
    // public AudioClip bgm;
    AudioSource audioSource;

    //Ç«Ç±Ç≈Ç‡é¿çs
    public static kitchensound instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        //ComponentÇéÊìæ
        audioSource = GetComponent<AudioSource>();
    }

    public void BGMstart()
    {
        audioSource.Play();
    }


    public void BGMstop()
    {
        audioSource.Stop();
    }
}
