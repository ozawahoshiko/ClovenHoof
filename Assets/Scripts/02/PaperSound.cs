using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSound : MonoBehaviour
{
    public AudioClip paper;
    AudioSource audioSource;

    public static PaperSound instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void Papersound()
    {
        audioSource.PlayOneShot(paper);

    }
}
