using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class officeSound : MonoBehaviour
{
    public AudioClip office;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void officesound()
    {
        audioSource.PlayOneShot(office);
    }
}
