using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuStageChange : MonoBehaviour
{
    // •\Ž¦‚µ‚Ä‚¢‚é‰æ‘œ
    public Image stage;
    public Sprite[] source;
    public void Start()
    {

        stage.sprite = GetSource();

    }

    Sprite GetSource()
    {

        int seneNum = 2;
        seneNum=GameManage.instance.returnNum();
        seneNum += -1;

        return source[seneNum];
    }
}
