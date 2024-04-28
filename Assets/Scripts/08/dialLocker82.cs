using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;



public class dialLocker82 : MonoBehaviour
{
    public AudioClip click;
    AudioSource audioSource;
    [SerializeField] GameObject hummeropen,mirrorzoom2;

   

    public Fungus.Flowchart flowchart = null;
    // �\�����Ă���摜
    public Image[] dialogs;

    public static dialLocker82 instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {

        audioSource = GetComponent<AudioSource>();
    }

    //�摜�̃\�[�X
    public Sprite[] markSources;
    //�}�[�N�̎�ށ{MAX
    enum Mark
    {
        no0 = 0,
        no1 = 1,
        no2 = 2,
        no3 = 3,
        no4 = 4,
        no5 = 5,
        no6 = 6,
        max = 7,
    }
    //���̐�
    Mark[] currentMarks =
    {
        Mark.no0,
        Mark.no0,
        Mark.no0,
        Mark.no0,


    };
    //�N���A����
    Mark[] clearMarks =
{       Mark.no5,
        Mark.no3,
        Mark.no6,
        Mark.no1,

    };

    //�{�^���N���b�N����
    public void OnClickDialog(int position)
    {
        ChangeMark(position);
        ShowMarkImage(position);
        audioSource.PlayOneShot(click);
        //�N���A�`�F�b�N
        if (IsClear() == true)
        {
            Cleared();
        }
    }
    //�N���A�Ƃ�
    bool IsClear()
    {
        if (currentMarks[0] == clearMarks[0]
            && currentMarks[1] == clearMarks[1]
            && currentMarks[2] == clearMarks[2]
             && currentMarks[3] == clearMarks[3]

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
        openshflag = true;
        mirrorzoom2.SetActive(true);
        mirrorControl.instance.mirrorPlay();
    }

public bool CheckOpen()
    {
        return openshflag;
    }


    //�}�[�N�ϐ���ύX
    void ChangeMark(int position)
    {
        currentMarks[position]++;
        if (currentMarks[position] >= Mark.max)
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