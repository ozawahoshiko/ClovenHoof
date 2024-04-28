using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
[RequireComponent(typeof(PlayableDirector))]

public class ricoInBox : MonoBehaviour
{
    [SerializeField] Item.Name axe;
    public GameObject cutIn,box,hintmenu,arrows;

    // ここにインスペクター上であらかじめ複数のセット
    [SerializeField] private TimelineAsset timelines;
    //PlayableDirector型の変数directorを宣言
    private PlayableDirector director;
    void Start()
    {
        //同じオブジェクトに付いているPlayableDirectorコンポーネントを取得
        director = this.GetComponent<PlayableDirector>();
    }
    public void OnclickBox()
    {
        bool clear = ItemBox13.instance.TryUseItem(axe);
        if (clear)
        {
            restaurantbgm.instance.BGMstop();
            cutIn.SetActive(true);
            //アニメ開始
            director.Play(timelines);
            //HideUsedItem.instance.HideUsedItems(60);
            //HideUsedItem.instance.HideUsedItems(54);
            //HideUsedItem.instance.HideUsedItems(61);
            //ボックス等も隠す
            box.SetActive(false);
            hintmenu.SetActive(false);
            arrows.SetActive(false);
        }

    }

}
