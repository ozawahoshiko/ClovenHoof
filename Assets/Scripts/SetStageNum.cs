using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetStageNum : MonoBehaviour
{
    [SerializeField] private int StageNum;
    // public GameObject fadepanel;

     
    
    public void SetNum()
    {
        AdmobBanner.instance.DestroyBannerView();
        // イベントにメソッドを登録
        SceneManager.sceneLoaded += GameSceneLoaded;

       // StartCoroutine(Color_FadeIn());


        SceneManager.LoadScene("Menu");

        void GameSceneLoaded(Scene next, LoadSceneMode mode)
        {
            // シーン切り替え後のスクリプトを取得
            var gameManager = GameObject.FindWithTag("GameManage").GetComponent<GameManage>();
            //次のシーンに数値を渡す
            gameManager.seneNum = StageNum; 

            // イベントからメソッドを削除
            SceneManager.sceneLoaded -= GameSceneLoaded;
          

        }
    }

    /*IEnumerator Color_FadeIn()
    {
        Debug.Log("ちゃーりー");
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
    }*/
}
