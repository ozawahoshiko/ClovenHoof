using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Cerberus4 : MonoBehaviour
{
    [SerializeField] Item.Name feed;
    [SerializeField] Sprite nomal,cerbthrow;
    public Fungus.Flowchart flowchart = null;
    
    public AudioClip baw;
    AudioSource audioSource;

    //#4で追加
    bool fingerOff = false;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();

    }
    public void ThrowFinger1()
    {
        bool clear = ItemBox13.instance.TryUseItem(feed);
        //指が出た後
        if (fingerOff)
        {
            //えさががあれば
            if (clear)
            {
                //#4ご飯あげる
                HideUsedItem.instance.HideUsedItems((int)feed);
                audioSource.PlayOneShot(baw);
                flowchart.SendFungusMessage("eat");
            }
            else
            {
                flowchart.SendFungusMessage("nofeed");
            }

        }
        else
        {
            fingerOff = true;
            //指吐き出す
            audioSource.PlayOneShot(baw);
            flowchart.SendFungusMessage("finger");
            this.GetComponent<Image>().sprite = cerbthrow;
        }
       

    }
    //食べる（ダイアログよりよびだし）
    public void Eat()
    {
       
        gameObject.SetActive(false);
        flowchart.SendFungusMessage("ending");
        //GameManage.instance.GoMenu();
    }

    public void CloseMouse()
    {
        this.GetComponent<Image>().sprite =nomal;
    }

    public void StopSound()
    {
        audioSource.Stop();
    }
}
