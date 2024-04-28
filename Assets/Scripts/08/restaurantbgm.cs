using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restaurantbgm : MonoBehaviour
{
   // public AudioClip bgm;
    AudioSource audioSource;

    //�ǂ��ł����s
    public static restaurantbgm instance;

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

    public void BGMstart()
    {
        audioSource.Play();
    }


    public void BGMstop()
    {
        audioSource.Stop();
    }
}
