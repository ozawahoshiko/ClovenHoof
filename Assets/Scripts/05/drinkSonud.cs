using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drinkSonud : MonoBehaviour
{
    public AudioClip drink;
    AudioSource audioSource;
 
    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void drinksound()
    {
        audioSource.PlayOneShot(drink);
    }
}
