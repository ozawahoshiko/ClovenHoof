using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class moriCheck : MonoBehaviour
{
    [SerializeField] string message;
    public Fungus.Flowchart flowchart = null;
    //クリア条件

    //完成ボタンをおされたとき
    public void OnclickCheck1()
    {//1043
        if (Dish.instance.CheckFoods(1,0,3,0,2))
        {
           
            flowchart.SendFungusMessage(message);
        }
        else
        {
            flowchart.SendFungusMessage("miss");
           
        }
        

    }
    //31124
    public void OnclickCheck2()
    {
        if (Dish2.instance.CheckFoods(2,0,0,1,3))
        {          
            flowchart.SendFungusMessage(message);
        }
        else
        {
            flowchart.SendFungusMessage("miss");
           
        }


    }
    //43112
    public void OnclickCheck3()
    {
        if (Dish3.instance.CheckFoods(2, 0, 3, 0, 1)|| Dish3.instance.CheckFoods(2, 0, 0, 3, 1))
        {
 
            flowchart.SendFungusMessage(message);
        }
       
        else
        {
            flowchart.SendFungusMessage("miss");
            
        }


    }


}
