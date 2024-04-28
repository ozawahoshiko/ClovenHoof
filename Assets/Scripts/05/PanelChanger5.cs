using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class PanelChanger5 : MonoBehaviour
{
    public GameObject RightArrow, LeftArrow, Up, Down;
    public Fungus.Flowchart flowchart = null;
    bool fromkitchen = false;
    //�ǂ��ł����s
    public static PanelChanger5 instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    //�B��
    public void HideArrows()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);

    }

    //���\��
    public void ArrowDisplay()
    {
        //�L�b�`��
        if (Mathf.Floor(this.transform.position.x) == 12)
        {
            HideArrows();
            RightArrow.SetActive(true);
            kitchensound.instance.BGMstart();
            fromkitchen = true;
        }//�t�����g
        else if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == 11)
        {
            HideArrows();
            Up.SetActive(true);
            LeftArrow.SetActive(true);
        }//�h���L����
        else if (Mathf.Floor(this.transform.position.x) == 6 && Mathf.Floor(this.transform.position.y) == -1)
        {
            HideArrows();
            RightArrow.SetActive(true);
        }//�X�^�b�t���[��
        else if (Mathf.Floor(this.transform.position.x) == 6 && Mathf.Floor(this.transform.position.y) == 11)
        {
            HideArrows();
            RightArrow.SetActive(true);
            LeftArrow.SetActive(true);
            if (fromkitchen)
            {
                kitchensound.instance.BGMstop();
                fromkitchen = false;
            }
        }//�G��
        else if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == -12)
        {
            HideArrows();
            //RightArrow.SetActive(true);
            Down.SetActive(true);
        }
        else
        {
            HideArrows();
            LeftArrow.SetActive(true);
            Up.SetActive(true);
            Down.SetActive(true);
        }

    }

    //�ŏ��̓���
    private void Start()
    {
        HideArrows();

        this.transform.localPosition = new Vector2(0,0);
    }

   
    //�p�l���ړ��֐�
    public void GoRight()
    {
        
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.x += -1500f;
        this.transform.localPosition = localpos;
        ArrowDisplay();

        //�����o�Ă���~�߂�
        if (water.instance.CheckWater())
        {
            water.instance.HideWater();
        }

    }
    
    public void GoLeft()
    {
        
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.x += 1500f;
        this.transform.localPosition = localpos;
        ArrowDisplay();
        if (wolfControl.instance.MessageCheck()&& Mathf.Floor(this.transform.position.x) == 12)
        {
            flowchart.SendFungusMessage("spidyStart");
            wolfControl.instance.SetFalse();
        }
        
    }
    public void GoUp()
    {
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.y += -3000f;
        this.transform.localPosition = localpos;
        ArrowDisplay();
    }
    public void GoDown()
    {
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.y += 3000f;
        this.transform.localPosition = localpos;
        ArrowDisplay();

    }


}