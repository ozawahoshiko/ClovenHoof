using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] GameObject testobj;
    // Start is called before the first frame update
    void Start()
    {
        testobj.SetActive(false);
    }

    // Update is called once per frame
    public void testt()
    {
       
        Debug.Log("korosu...");
        testobj.SetActive(true);
    }
}
