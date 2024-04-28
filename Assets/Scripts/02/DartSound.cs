using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartSound : MonoBehaviour
{
    public AudioClip darts;
    AudioSource audioSource;

    public static DartSound instance;

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
    public void Dartssound()
    {
        audioSource.PlayOneShot(darts);

    }
}
