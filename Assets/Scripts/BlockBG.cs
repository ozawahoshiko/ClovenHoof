using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBG : MonoBehaviour
{
    //Ç«Ç±Ç≈Ç‡é¿çs
    public static BlockBG instance;

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        
    }

    // Start is called before the first frame update
    public void HideBlock()
    {
        gameObject.SetActive(false);
    }
    public void ShowBlock()
    {
        gameObject.SetActive(true);
    }
}
