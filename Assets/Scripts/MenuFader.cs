using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuFader : MonoBehaviour
{
    public GameObject fadepanel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Color_FadeIn());
  
    }

    IEnumerator Color_FadeIn()
    {
    
        // 画面をフェードインさせるコールチン
        // 前提：画面を覆うPanelにアタッチしている
        Image fade = fadepanel.GetComponent<Image>();

        // フェード元の色を設定（黒）★変更可
        fade.color = new Color((0.0f / 255.0f), (0.0f / 255.0f), (0.0f / 0.0f), (255.0f / 255.0f));

        // フェードインにかかる時間（秒）★変更可
        const float fade_time = 0.6f;

        // ループ回数（0はエラー）★変更可
        const int loop_count = 10;
        float wait_time = fade_time / loop_count;
        float alpha_interval = 255.0f / loop_count;
        for (float alpha = 255.0f; alpha >= 0.0f; alpha -= alpha_interval)
        {
            yield return new WaitForSeconds(wait_time);
            Color new_color = fade.color;
            new_color.a = alpha / 255.0f;
            fade.color = new_color;
        }
        fadepanel.SetActive(false);
        //広告呼び出し

        AdmobBanner.instance.LoadAd2();

    }
}
