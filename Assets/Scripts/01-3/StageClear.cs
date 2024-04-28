using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClear : MonoBehaviour
{//どこでも実行
    public static StageClear instance;
    private Animator anim;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
   

    void Start()
    {
        //変数animに、Animatorコンポーネントを設定する
        anim = gameObject.GetComponent<Animator>();
    }
    public void StageClearStamp()
    {
        //アニメーション開始、ステージクリアスタンプ
        anim.SetBool("stageclear", true);
        //transform.SetAsLastSibling();

    }
}
