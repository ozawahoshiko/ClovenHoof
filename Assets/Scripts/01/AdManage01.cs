using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdManage01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
      AdmobBanner.instance.LoadAd();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
