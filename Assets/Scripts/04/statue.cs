using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class statue : MonoBehaviour
{
    [SerializeField] Item.Name clearItem;
    public Fungus.Flowchart flowchart = null;
    public AudioClip putStatue;
    AudioSource audioSource;
    public bool endTalkFlag;
    [SerializeField] GameObject statuezoom;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }
    //public GameObject itemImage;

    bool statueset = false;
    public void Onclick()
    {
        bool clear = ItemBox13.instance.TryUseItem(clearItem);
        //おされたとき、もし胸像がそろっていたらズームする
        if (statueset)
        {
            statuezoom.SetActive(true);
            BlockBG.instance.ShowBlock();
            //クリックされたらダイアログも呼ぶ
            CallDialog();
        }    // 推された時、アイテムを持っていれば色を白にしてアイテムを消す
        else if (clear)
        {
            this.GetComponent<Image>().color = Color.white;
            HideUsedItem.instance.HideUsedItems((int)clearItem);
            audioSource.PlayOneShot (putStatue);
            statueset = true;

        }
    }

    //もしマッチを持った時に像がアイテム欄にあれば消してアイテム出す

    public void SetStatue()
    {
        if (ItemBox13.instance.CheckItemAllBox(clearItem))
        {
            this.GetComponent<Image>().color = Color.white;
            HideUsedItem.instance.HideUsedItems((int)clearItem);
        }
    }

    public void CallDialog()
    {
            flowchart.SetIntegerVariable("room",63);
            flowchart.SendFungusMessage("roomzoom");
            endTalkFlag = false;
     
    }
    public void CloseStatueZoom()
    {
        statuezoom.SetActive(false);
    }
}
