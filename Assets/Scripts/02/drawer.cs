using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : MonoBehaviour
{

    public AudioClip officedrawer;
    AudioSource audioSource;
    public static drawer instance;

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
    // Start is called before the first frame update
    public void drawersound()
    {
        audioSource.PlayOneShot(officedrawer);
    }
}
