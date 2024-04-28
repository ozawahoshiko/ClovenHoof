using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManage : MonoBehaviour
{
    public void Start()
    {
        menupanel.SetActive(false);
    }

    [SerializeField] GameObject menupanel;
      public void Close(){
          menupanel.SetActive(false);
      
      //  AdmobBanner.instance.LoadAd();
    }
    public void Open()
    {
        menupanel.SetActive(true);
       // AdmobBanner.instance.DestroyBannerView();
   
    }
    public void GoStageSelect()
    {
        GameManage.instance.GoStageSelect();
    }

}
