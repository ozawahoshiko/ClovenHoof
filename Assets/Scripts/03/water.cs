using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    public bool waterRun = false;


    public AudioClip waters;
    AudioSource audioSource;
    public GameObject waterr;

    public static water instance;
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
    public void ShowWater()
    {
        if (GameObject.Find("water"))
        {
            HideWater();
            waterRun = false;
        }
        else
        {
            waterr.SetActive(true);
            audioSource.PlayOneShot(waters);
            waterRun = true;
        }
       
    }
    public void HideWater()
    {
        waterr.SetActive(false);
        //SoundMaker.instance.Stop();
        audioSource.Stop();
        waterRun = false;
    }

    public bool CheckWater()
    {
        return waterRun;
    }
}
