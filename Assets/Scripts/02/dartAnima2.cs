using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartAnima2 : MonoBehaviour
{
    private Vector3 pos;
    //Vector2(0, 3000)

    //Animator animator;
    // Start is called before the first frame update
    void Start()
    {
       //pos = new Vector3(5, 5, 5);
        
    }

    public void Update()
    {
        pos = transform.position;
        if (dartshoot.instance.SetDartFlag2()){
            if (pos.x > 1.65f)
            {
               // transform.Translate(-0.1f, -0.1f, 0);
              
                transform.Translate(-0.17f, -0.09f, 0);
            }
            

        }


    }
}