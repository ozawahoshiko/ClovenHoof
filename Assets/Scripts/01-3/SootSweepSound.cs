using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SootSweepSound : MonoBehaviour
{ 
    public AudioClip sootswipe;
   AudioSource audioSource;
    public static SootSweepSound instance;
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
    public void Swipesound()
    {
        audioSource.PlayOneShot(sootswipe);
      
    }
}
