using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageClear : MonoBehaviour
{//�ǂ��ł����s
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
        //�ϐ�anim�ɁAAnimator�R���|�[�l���g��ݒ肷��
        anim = gameObject.GetComponent<Animator>();
    }
    public void StageClearStamp()
    {
        //�A�j���[�V�����J�n�A�X�e�[�W�N���A�X�^���v
        anim.SetBool("stageclear", true);
        //transform.SetAsLastSibling();

    }
}
