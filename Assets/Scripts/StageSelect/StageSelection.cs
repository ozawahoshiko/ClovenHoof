using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelection : MonoBehaviour
{
    public GameObject door2,door2Ng, door3, door3Ng,door4, door4Ng, door5, door5Ng, door6, door6Ng, door7, door7Ng, door8, door8Ng;
    // Start is called before the first frame update
    void Start()
    {
        //‚à‚µStage1‚ªƒNƒŠƒA‚µ‚Ä‚¢‚½‚ç
        if (GameManage.instance.LoadStage1Data())
        {
            door2.SetActive(true);
            door2Ng.SetActive(false);
        }
        else
        {
            door2.SetActive(false);
            door2Ng.SetActive(true);
        }

        if (GameManage.instance.LoadStage2Data())
        {
            door3.SetActive(true);
            door3Ng.SetActive(false);  
        }
        else
        {
            door3.SetActive(false);
            door3Ng.SetActive(true);
        }
        if (GameManage.instance.LoadStage3Data())
        {
            door4.SetActive(true);
            door4Ng.SetActive(false);
        }
        else
        {
            door4.SetActive(false);
            door4Ng.SetActive(true);
        }
        if (GameManage.instance.LoadStage4Data())
        {
            door5.SetActive(true);
            door5Ng.SetActive(false);
        }
        else
        {
            door5.SetActive(false);
            door5Ng.SetActive(true);
        }
        if (GameManage.instance.LoadStage5Data())
        {
            door6.SetActive(true);
            door6Ng.SetActive(false);
        }
        else
        {
            door6.SetActive(false);
            door6Ng.SetActive(true);
        }
        if (GameManage.instance.LoadStage6Data())
        {
            door7.SetActive(true);
            door7Ng.SetActive(false);
        }
        else
        {
            door7.SetActive(false);
            door7Ng.SetActive(true);
        }
        if (GameManage.instance.LoadStage7Data())
        {
            door8.SetActive(true);
            door8Ng.SetActive(false);
        }
        else
        {
            door8.SetActive(false);
            door8Ng.SetActive(true);
        }

    }

  
}
