using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
[RequireComponent(typeof(PlayableDirector))]

public class lastScene : MonoBehaviour
{
    public GameObject blackback, buttons, button3,last,last2;

    // �����ɃC���X�y�N�^�[��ł��炩���߃Z�b�g
   // [SerializeField] private TimelineAsset timelines2;
    //PlayableDirector�^�̕ϐ�director��錾
    private PlayableDirector director;
    public Fungus.Flowchart flowchart = null;

    void Start()
    {
        //�����I�u�W�F�N�g�ɕt���Ă���PlayableDirector�R���|�[�l���g���擾
       // director = this.GetComponent<PlayableDirector>();
    }

    //�u���b�N�A�E�g�폜
    //�l�����Ԃʂ�V�[��
    //�Z���t�X�^�[�g
    public void lastStart()
    {
        blackback.SetActive(false);
        last.SetActive(true);
        //director.Play(timelines2);
        flowchart.SendFungusMessage("lastdialog");

    }

    //��������
    public void ownerShow()
    {
        last2.SetActive(true);
    }
        //�{�^���o������
        public void buttonShow()
    {
        //��������Ă������O�̑I�������o��
        if (dialLocker82.instance.CheckOpen())
        {
            buttons.SetActive(true);
            button3.SetActive(true);
        }
        else
        {
            buttons.SetActive(true);
        }
       

    }
}
