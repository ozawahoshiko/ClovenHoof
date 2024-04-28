using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kitchensound : MonoBehaviour
{
    // public AudioClip bgm;
    AudioSource audioSource;

    //どこでも実行
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
        //Componentを取得
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
