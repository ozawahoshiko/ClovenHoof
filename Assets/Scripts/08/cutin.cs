using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutin : MonoBehaviour
{
    //�C���X�^���X��
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
        //�ϐ�anim�ɁAAnimator�R���|�[�l���g��ݒ肷��
        anim = gameObject.GetComponent<Animator>();
        
    }

    // �J�b�g�C���A�j��
    public void cutInAnime()
    {
        anim.SetBool("cutAndIn", true);
        //flowchart.SendFungusMessage("cutin");
        
    }
}
