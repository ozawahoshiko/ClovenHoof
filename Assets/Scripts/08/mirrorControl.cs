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

    // ここにインスペクター上であらかじめ複数のセット
    [SerializeField] private TimelineAsset timelines;
    //PlayableDirector型の変数directorを宣言
    private PlayableDirector director;

    //どこでも実行
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
        //同じオブジェクトに付いているPlayableDirectorコンポーネントを取得
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
