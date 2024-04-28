using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Twitter : MonoBehaviour
{
    public void OnClickTwitterButton()
    {
        //urlの作成
        string esctext = UnityWebRequest.EscapeURL("脱出ゲーム　CLOVEN HOOF\nhttps://hitodenaishi.hatenablog.com/");
        string esctag = UnityWebRequest.EscapeURL("悪魔ホテルからの脱出");
        string url = "https://twitter.com/intent/tweet?text=" + esctext + "&hashtags=" + esctag;

        //Twitter投稿画面の起動
        Application.OpenURL(url);

    }
    public void gourl()
    {
        Application.OpenURL("https://twitter.com/starchildco");
    }
}
