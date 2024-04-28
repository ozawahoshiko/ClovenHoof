using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmSoundctr : MonoBehaviour
{
    AudioSource audioSource;

   // public bool IsFade;
    //public double FadeOutSeconds = 1.0;
    //bool IsFadeOut = false;
    //double FadeDeltaTime = 0;

    //Ç«Ç±Ç≈Ç‡é¿çs
    public static bgmSoundctr instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void BGMstart()
    {
        audioSource.Play();
    }


    public void BGMstop()
    {
        StartCoroutine("VolumeDown");
    }


    IEnumerator VolumeDown()
    {
        while (audioSource.volume > 0)
        {
            audioSource.volume -= 0.008f;
            yield return new WaitForSeconds(0.1f);
        }
    }
    public void soundshutdown()
    {
        audioSource.Stop();
    }
}
