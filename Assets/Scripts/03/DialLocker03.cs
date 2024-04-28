using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class DialLocker03 : MonoBehaviour
{//どこでも実行
    public static DialLocker03 instance;
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
    // 表示している画像
    public Image[] dialogs;

    //画像のソース
    public Sprite[] markSources;
    //マークの種類＋MAX
    enum Mark
    {
        no0 =0,
        no1 = 1,
        no2 = 2,
        no3 = 3,
        no4 = 4,
        no5 = 5,
        no6 = 6,
        no7 = 7,
        no8 = 8,
        no9 = 9,
        max =10,
    }
    //鍵の数
    Mark[] currentMarks =
    {
        Mark.no0,
        Mark.no0,
        Mark.no0,

    };
    //クリア条件
    Mark[] clearMarks =
{       Mark.no6,
        Mark.no6,
        Mark.no6,

    };

    //効果音
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    //ボタンクリック処理
    public void OnClickDialog(int position)
    {
        ChangeMark(position);
        ShowMarkImage(position);
        audioSource.PlayOneShot(click);
        //クリアチェック
        if (IsClear() == true)
        {
            Invoke("Cleared", 1);
        }
    }
    //クリアとは
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
    //クリアしたときの処理
    public bool openshflag = false;
    void Cleared()
    {
        //ブラシの文言を呼ぶ
        HideUsedItem.instance.HideUsedItems(31);
        flowchart.SendFungusMessage("shopen");
        openshflag = true;
      
    }

    public bool CheckOpen()
    {
        return openshflag;
    }
    
   
    //マーク変数を変更
    void ChangeMark(int position)
    {
        currentMarks[position]++;
        if (currentMarks[position] >= Mark.max)
        {
            currentMarks[position] = Mark.no0;
        }
    }

    //マーク変数に応じて画像表示
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
