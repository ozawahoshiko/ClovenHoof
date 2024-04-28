using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class DialLocker04 : MonoBehaviour
{//�ǂ��ł����s
    public static DialLocker04 instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public AudioClip click;
    AudioSource audioSource;
 
    public Fungus.Flowchart flowchart = null;
    // �\�����Ă���摜
    public Image[] dialogs;

    //�摜�̃\�[�X
    public Sprite[] markSources;
    //�}�[�N�̎�ށ{MAX
    enum Mark
    {
        no0 =0,
        no1 = 1,
        no2 = 2,
        no3 = 3,
        no4 = 4,
        no5 = 5,
        max =6,

    }
    //���̐�
    Mark[] currentMarks =
    {
        Mark.no0,
        Mark.no0,
        Mark.no0,

    };
    //�N���A����
    Mark[] clearMarks =
{       Mark.no0,
        Mark.no3,
        Mark.no2,

    };

    //���ʉ�
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    //�{�^���N���b�N����
    public void OnClickDialog(int position)
    {
     
        ChangeMark(position);
        ShowMarkImage(position);
        audioSource.PlayOneShot(click);
        //�N���A�`�F�b�N
        //Debug.Log(" ��0�F" + currentMarks[0]+ " ��1�F" + currentMarks[1]+ " ��2�F" + currentMarks[2]);
        if (IsClear() == true)
        {
            Invoke("Cleared", 1);
        }
    }
    //�N���A�Ƃ�
    bool IsClear()
    {
        if(currentMarks[0]== clearMarks[0]
            && currentMarks[1] == clearMarks[1]
            && currentMarks[2] == clearMarks[2]


            )
        {
            return true;
        }
        return false;
    }
    //�N���A�����Ƃ��̏���
    public bool openshflag = false;
    void Cleared()
    {
        //�u���V�̕������Ă�
        //HideUsedItem.instance.HideUsedItems(31);
        flowchart.SendFungusMessage("fpopen");
        openshflag = true;
      
    }

    public bool CheckOpen()
    {
        return openshflag;
    }
    
   
    //�}�[�N�ϐ���ύX
    void ChangeMark(int position)
    {
        currentMarks[position]++;
        if (currentMarks[position] == Mark.max)
        {
            currentMarks[position] = Mark.no0;
        }
    }

    //�}�[�N�ϐ��ɉ����ĉ摜�\��
    void ShowMarkImage(int position)
    {
        dialogs[position].sprite = GetSource(currentMarks[position]);
    }
     Sprite GetSource(Mark mark)
    {
        int markIndex = (int)mark;
        return markSources[markIndex];
    }
    
   
}