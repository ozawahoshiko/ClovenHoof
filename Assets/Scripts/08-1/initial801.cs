
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initial801 : MonoBehaviour
{
    public GameObject
         image;

    void Start()
    {
        image.SetActive(false);
      

    }

    public void appearImage()
    {
        image.SetActive(true);
    }

   
}
