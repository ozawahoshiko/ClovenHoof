using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassBroke : MonoBehaviour
{
    [SerializeField] AudioClip sound;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void glassbroke()
    {
        audioSource.PlayOneShot(sound);
    }
}
