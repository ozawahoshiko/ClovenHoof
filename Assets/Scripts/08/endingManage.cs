using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
[RequireComponent(typeof(PlayableDirector))]

public class endingManage : MonoBehaviour
{
    // ここにインスペクター上であらかじめ複数のセット
    [SerializeField] private TimelineAsset[] endings;
    //PlayableDirector型の変数directorを宣言
    private PlayableDirector director;

    public Fungus.Flowchart flowchart = null;
    public GameObject buttons, edButton3, last, last2,showTime, endImg3;

    void Start()
    {
        //同じオブジェクトに付いているPlayableDirectorコンポーネントを取得
       // director = this.GetComponent<PlayableDirector>();
    }

    //一人で帰る
    public void endbutton1()
    {
        buttons.SetActive(false);
        edButton3.SetActive(false);
        last.SetActive(false);
        last2.SetActive(false);
        showTime.SetActive(false);
        flowchart.SendFungusMessage("ed01");
        AdmobBanner.instance.DestroyBannerView();
    }
    //二人で帰る
    public void endbutton2()
    {
        buttons.SetActive(false);
        edButton3.SetActive(false);
        last.SetActive(false);
        last2.SetActive(false);
        showTime.SetActive(false);
        flowchart.SendFungusMessage("ed02");
        AdmobBanner.instance.DestroyBannerView();
    }
    //TrueEnd
    public void endbutton3()
    {
        buttons.SetActive(false);
        edButton3.SetActive(false);
        last.SetActive(false);
        last2.SetActive(false);
        showTime.SetActive(false);
        flowchart.SendFungusMessage("ed031");
        AdmobBanner.instance.DestroyBannerView();
    }
    public void trueEndImg()
    {
        endImg3.SetActive(true);
        flowchart.SendFungusMessage("ed032");
        
    }
}
