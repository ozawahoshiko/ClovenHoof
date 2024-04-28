using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openbyKey : MonoBehaviour
{
    [SerializeField] Item.Name key;
    [SerializeField] GameObject batszoom,batsnumzoom, hummeropen, b0,b1,b2,b3;
    [SerializeField] Sprite openbatszoom, hidehummer;

    public AudioClip openkey;
    AudioSource audioSource;

    public void Start()
    {
        b0.SetActive(false);
        b1.SetActive(false); 
        b2.SetActive(false);
        b3.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }
    public void OpenbyKey()
    {
        bool clear = ItemBox13.instance.TryUseItem(key);
        //もしスロット画像がclearItem1(鍵)がはいっていれば
        if (clear == true)
        {
            //開いた蝙蝠のズームに画像差し替え
            batsnumzoom.GetComponent<Image>().sprite = openbatszoom;
            b0.SetActive(true);
            b1.SetActive(true);
            b2.SetActive(true);
            b3.SetActive(true);
            audioSource.PlayOneShot(openkey);
        }
    }
    public void Showme()
    {
        if (dialLocker8.instance.CheckOpen())
        {
            audioSource.PlayOneShot(openkey);
            hummeropen.SetActive(true);
            
        }
        else
        {
             batsnumzoom.SetActive(true);
        }
       
    }

    public void Hidehummer()
    {
        batszoom.GetComponent<Image>().sprite = hidehummer;
    }

    public void sound()
    {
        audioSource.PlayOneShot(openkey);
    }

}
