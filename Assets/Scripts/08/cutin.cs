using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutin : MonoBehaviour
{
    //インスタンス化
    public static cutin instance;
    public Fungus.Flowchart flowchart = null;
  

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }
    private Animator anim;
    void Start()
    {
        //変数animに、Animatorコンポーネントを設定する
        anim = gameObject.GetComponent<Animator>();
        
    }

    // カットインアニメ
    public void cutInAnime()
    {
        anim.SetBool("cutAndIn", true);
        //flowchart.SendFungusMessage("cutin");
        
    }
}
