using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
[RequireComponent(typeof(PlayableDirector))]

public class lastScene : MonoBehaviour
{
    public GameObject blackback, buttons, button3,last,last2;

    // ここにインスペクター上であらかじめセット
   // [SerializeField] private TimelineAsset timelines2;
    //PlayableDirector型の変数directorを宣言
    private PlayableDirector director;
    public Fungus.Flowchart flowchart = null;

    void Start()
    {
        //同じオブジェクトに付いているPlayableDirectorコンポーネントを取得
       // director = this.GetComponent<PlayableDirector>();
    }

    //ブラックアウト削除
    //人魚ずぶぬれシーン
    //セリフスタート
    public void lastStart()
    {
        blackback.SetActive(false);
        last.SetActive(true);
        //director.Play(timelines2);
        flowchart.SendFungusMessage("lastdialog");

    }

    //悪役現る
    public void ownerShow()
    {
        last2.SetActive(true);
    }
        //ボタン出し入れ
        public void buttonShow()
    {
        //鏡をやっていたら第三の選択肢が出る
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
