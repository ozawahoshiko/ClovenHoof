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
        // �C�x���g�Ƀ��\�b�h��o�^
        SceneManager.sceneLoaded += GameSceneLoaded;

       // StartCoroutine(Color_FadeIn());


        SceneManager.LoadScene("Menu");

        void GameSceneLoaded(Scene next, LoadSceneMode mode)
        {
            // �V�[���؂�ւ���̃X�N���v�g���擾
            var gameManager = GameObject.FindWithTag("GameManage").GetComponent<GameManage>();
            //���̃V�[���ɐ��l��n��
            gameManager.seneNum = StageNum; 

            // �C�x���g���烁�\�b�h���폜
            SceneManager.sceneLoaded -= GameSceneLoaded;
          

        }
    }

    /*IEnumerator Color_FadeIn()
    {
        Debug.Log("����[��[");
        // ��ʂ��t�F�[�h�C��������R�[���`��
        // �O��F��ʂ𕢂�Panel�ɃA�^�b�`���Ă���
        Image fade = fadepanel.GetComponent<Image>();

        // �t�F�[�h���̐F��ݒ�i���j���ύX��
        fade.color = new Color((0.0f / 255.0f), (0.0f / 255.0f), (0.0f / 0.0f), (255.0f / 255.0f));

        // �t�F�[�h�C���ɂ����鎞�ԁi�b�j���ύX��
        const float fade_time = 0.6f;

        // ���[�v�񐔁i0�̓G���[�j���ύX��
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
