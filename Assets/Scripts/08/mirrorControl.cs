using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;
[RequireComponent(typeof(PlayableDirector))]

public class mirrorControl : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public GameObject mirrorzoom2,d0,d1,d2,d3;

    [SerializeField] GameObject bg;
    [SerializeField] Sprite mirrorchanged;

    // �����ɃC���X�y�N�^�[��ł��炩���ߕ����̃Z�b�g
    [SerializeField] private TimelineAsset timelines;
    //PlayableDirector�^�̕ϐ�director��錾
    private PlayableDirector director;

    //�ǂ��ł����s
    public static mirrorControl instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }
    void Start()
    {
        //�����I�u�W�F�N�g�ɕt���Ă���PlayableDirector�R���|�[�l���g���擾
        director = this.GetComponent<PlayableDirector>();
        //audioSource = GetComponent<AudioSource>();
    }

    public void mirrorPlay()
    {
        director.Play(timelines);
    }

    public void mirrorDialog1()
    {
        flowchart.SendFungusMessage("mirrordialog1");
        HideUsedItem.instance.HideUsedItems(61);
    }
    public void mirrorDialog2()
    {
        flowchart.SendFungusMessage("mirrordialog2");

    }
    public void mirrorDialog3()
    {
        mirrorzoom2.SetActive(false);
        //saydialog.SetActive(false);
        flowchart.SendFungusMessage("mirrordialog3");
    }
    public void mirrorDialog4()
    {
        flowchart.SendFungusMessage("mirrordialog4");
        bg.GetComponent<Image>().sprite = mirrorchanged;
        Destroy(d0);
        Destroy(d1);
        Destroy(d2);
        Destroy(d3);
        
    }
}
