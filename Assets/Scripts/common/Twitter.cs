using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Twitter : MonoBehaviour
{
    public void OnClickTwitterButton()
    {
        //url�̍쐬
        string esctext = UnityWebRequest.EscapeURL("�E�o�Q�[���@CLOVEN HOOF\nhttps://hitodenaishi.hatenablog.com/");
        string esctag = UnityWebRequest.EscapeURL("�����z�e������̒E�o");
        string url = "https://twitter.com/intent/tweet?text=" + esctext + "&hashtags=" + esctag;

        //Twitter���e��ʂ̋N��
        Application.OpenURL(url);

    }
    public void gourl()
    {
        Application.OpenURL("https://twitter.com/starchildco");
    }
}
