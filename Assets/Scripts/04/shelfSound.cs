using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shelfSound : MonoBehaviour
{

    public AudioClip shelfopen;
    AudioSource audioSource;

    public static shelfSound instance;

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
    // Start is called before the first frame update
    public void Shelfsound()
    {
        audioSource.PlayOneShot(shelfopen);

    }
}
