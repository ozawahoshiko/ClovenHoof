using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PanelChanger8 : MonoBehaviour
{
    public GameObject RightArrow, LeftArrow, Up, Down;
    public Fungus.Flowchart flowchart = null;
    public bool alreadyHide = false;
    //レストランから廊下に出た時だけ音を始めるため
    public bool fromrestaurant = false;
    bool fromkitchen = false;

    //隠す
    void HideArrows()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);

    }

    //矢印表示
    public void ArrowDisplay()
    {
       
        //キッチン
        if (Mathf.Floor(this.transform.position.x) == 12)
        {
            
            HideArrows();
            RightArrow.SetActive(true);
            kitchensound.instance.BGMstart();
            fromkitchen = true;
        }//フロント
        else if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == 11)
        {
           
            HideArrows();
            Up.SetActive(true);
            LeftArrow.SetActive(true);
        }//ドラキュラ
        else if (Mathf.Floor(this.transform.position.x) == 6 && Mathf.Floor(this.transform.position.y) == -1)
        {
           
            HideArrows();
            RightArrow.SetActive(true);
        }//スタッフルーム
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
        }//絵画
        else if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == -12)
        {
            HideArrows();
            
            RightArrow.SetActive(true);
            Down.SetActive(true);
            if (fromrestaurant)
            {
                restaurantbgm.instance.BGMstop();
                bgmsound.instance.BGMstart();
                fromrestaurant = false;
            }
        }
        //ろうか
        else if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == -1)
        {
            RightArrow.SetActive(true);
            LeftArrow.SetActive(true);
            Up.SetActive(true);
            Down.SetActive(true);
        }
        //レストラン
        else if (Mathf.Floor(this.transform.position.x) == -5 && Mathf.Floor(this.transform.position.y) == -12)
        {
            bgmsound.instance.BGMstop();
            HideArrows();
            LeftArrow.SetActive(true);
            restaurantbgm.instance.BGMstart();
            fromrestaurant = true;
           
        }
        else 
            { 
           
            HideArrows();
            LeftArrow.SetActive(true);
          
     
        }

    }

    //最初の動作
    private void Start()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);

        this.transform.localPosition = new Vector2(-1500, -3000);
    }


    //パネル移動関数
    public void GoRight()
    {

        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.x += -1500f;
        this.transform.localPosition = localpos;
        ArrowDisplay();



    }

    public void GoLeft()
    {

        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.x += 1500f;
        this.transform.localPosition = localpos;
        ArrowDisplay();
        if (owner8.instance.CheckPassed() && alreadyHide == false)
        {
            owner8.instance.HideOwner();
            alreadyHide = true;
           
        }

    }

    
    public void GoUp()
    {
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.y += -3000f;
        this.transform.localPosition = localpos;
        ArrowDisplay();
        if (owner8.instance.CheckPassed() && alreadyHide == false)
        {
            owner8.instance.HideOwner();
            alreadyHide = true;
           
        }
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
