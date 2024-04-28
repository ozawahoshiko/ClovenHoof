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
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }
    //public GameObject itemImage;

    bool statueset = false;
    public void Onclick()
    {
        bool clear = ItemBox13.instance.TryUseItem(clearItem);
        //�����ꂽ�Ƃ��A����������������Ă�����Y�[������
        if (statueset)
        {
            statuezoom.SetActive(true);
            BlockBG.instance.ShowBlock();
            //�N���b�N���ꂽ��_�C�A���O���Ă�
            CallDialog();
        }    // �����ꂽ���A�A�C�e���������Ă���ΐF�𔒂ɂ��ăA�C�e��������
        else if (clear)
        {
            this.GetComponent<Image>().color = Color.white;
            HideUsedItem.instance.HideUsedItems((int)clearItem);
            audioSource.PlayOneShot (putStatue);
            statueset = true;

        }
    }

    //�����}�b�`�����������ɑ����A�C�e�����ɂ���Ώ����ăA�C�e���o��

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
