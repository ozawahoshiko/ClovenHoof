using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class PanelChanger3 : MonoBehaviour
{
    public GameObject RightArrow, LeftArrow, Up, Down;
    public Fungus.Flowchart flowchart = null;
    bool fromkitchen = true;
    //隠す
    public void HideArrows()
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
        }
        else if (Mathf.Floor(this.transform.position.x) == 1 && Mathf.Floor(this.transform.position.y) == 11)
        {
            HideArrows();
            Up.SetActive(true);
            LeftArrow.SetActive(true);
        }
        else if (Mathf.Floor(this.transform.position.x) == 6 && Mathf.Floor(this.transform.position.y) == -1)
        {
            HideArrows();
            RightArrow.SetActive(true);
        }
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
        }
        else
        {
            HideArrows();
            LeftArrow.SetActive(true);
            Down.SetActive(true);
        }

    }

    //最初の動作
    private void Start()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        Up.SetActive(false);
        Down.SetActive(false);

        this.transform.localPosition = new Vector2(1500, 3000);
    }

   
    //パネル移動関数
    public void GoRight()
    {
        
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.x += -1500f;
        this.transform.localPosition = localpos;
        ArrowDisplay();

        //水が出てたら止める
        if (water.instance.CheckWater())
        {
            water.instance.HideWater();
        }

    }
    bool isFisttIme = true;
    public void GoLeft()
    {
        
        Transform myTrans = this.transform;
        Vector2 localpos = myTrans.localPosition;
        localpos.x += 1500f;
        this.transform.localPosition = localpos;
        ArrowDisplay();

        
        if (isFisttIme && Mathf.Floor(this.transform.position.x) == 12)
        {
            flowchart.SendFungusMessage("firstkitchen");

            isFisttIme = false;
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
