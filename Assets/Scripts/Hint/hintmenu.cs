using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CI.QuickSave;
using System.IO;


public class hintmenu : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] string stagenum;
    public GameObject hint1, hint2, ans, item1, item2,hintbtn1, hintbtn2, hintbtn3,
        hint1Text, hint2Text, ansText, item1Text, item2Text;
    public Sprite h1, h2, an, it1, it2,
        hint1cl,hint2cl,anscl,item1cl, item1c2;
    private Image   imageHint1, imageHint2, imageAns,imageItem1, imageItem2;



    bool didgetReward = false;
    bool didgetReward2 = false;
    bool didgetReward3 = false;

    QuickSaveSettings settings;
    QuickSaveWriter writer;
    bool adbool;
    private void Awake()
    {
        // データの保存先変更
        QuickSaveGlobalSettings.StorageLocation = Application.persistentDataPath;
        // QuickSaveSettingsのインスタンスを作成
        settings = new QuickSaveSettings();
        // 暗号化の方法 
        settings.SecurityMode = SecurityMode.Aes;
        // Aesの暗号化キー
        settings.Password = "xjEJDiegE+Any%";
        // 圧縮の方法
        settings.CompressionMode = CompressionMode.Gzip;
        // QuickSaveWriterのインスタンスを作成
        writer = QuickSaveWriter.Create("SaveStageData", settings);
        //ファイルなければつくる
        string fileName = Path.Combine(QuickSaveGlobalSettings.StorageLocation, @"QuickSave/SaveStageData.json");
        //Debug.Log("aaergsergser"+fileName);
        if (File.Exists(fileName))
        {
            
            return;
        }
        else
        {
            writer.Commit();
        }
     
    }

    void Start()
    {
       
       
        hint1Text.SetActive(false);
        hint2Text.SetActive(false);
        ansText.SetActive(false);
        item1Text.SetActive(true);
        item2Text.SetActive(false);
        hintbtn1.SetActive(false);
        hintbtn2.SetActive(false);
        hintbtn3.SetActive(false);
       
        imageHint1 = hint1.GetComponent<Image>();
        imageHint2 = hint2.GetComponent<Image>();
        imageAns = ans.GetComponent<Image>();
        imageItem1 = item1.GetComponent<Image>();
        imageItem2 = item2.GetComponent<Image>();



        if (Loadhint1Data())
        {
            hint2.SetActive(true);
            if (Loadhint2Data())
            {
                ans.SetActive(true);
               
            }
            else
            {
                ans.SetActive(false);
                
            }
        }
        else
        {
            hint2.SetActive(false);
            ans.SetActive(false);
        }




    }
    public bool Loadhint1Data()
    {
        QuickSaveReader reader = QuickSaveReader.Create("SaveStageData", settings);
        //stageは中身なくていい

        if (reader.TryRead<bool>(stagenum+"1", out adbool) == false)
        {
            adbool = false;
        }
        else
        {
            adbool = reader.Read<bool>(stagenum + "1");
        }
        return adbool;
    }
    public bool Loadhint2Data()
    {
        QuickSaveReader reader = QuickSaveReader.Create("SaveStageData", settings);
        //stageは中身なくていい

        if (reader.TryRead<bool>(stagenum + "2", out adbool) == false)
        {
            adbool = false;
        }
        else
        {
            adbool = reader.Read<bool>(stagenum + "2");
        }
        return adbool;
    }
    public bool Loadhint3Data()
    {
        QuickSaveReader reader = QuickSaveReader.Create("SaveStageData", settings);
   
        if (reader.TryRead<bool>(stagenum + "3", out adbool) == false)
        {
            adbool = false;
        }
        else
        {
            adbool = reader.Read<bool>(stagenum + "3");
        }
        return adbool;
    }
    public void hint1Onclick()
    {
        allitemUnActive();
        imageHint1.sprite = hint1cl;
       

        if (Loadhint1Data())
        {
            hint1Text.SetActive(true);
        }
        else
        {
            hintbtn1.SetActive(true);
        }
        
    }
    public void hint2Onclick()
    {
        allitemUnActive();
        imageHint2.sprite = hint2cl;
        if (Loadhint2Data())
        {
            hint2Text.SetActive(true);
        }
        else
        {
            hintbtn2.SetActive(true);
        }
       
    }
    public void ansOnclick()
    {
        allitemUnActive();
        imageAns.sprite = anscl;
       
        if (Loadhint3Data())
        {
            ansText.SetActive(true);
        }
        else
        {
            hintbtn3.SetActive(true);
        }
    }
    public void item1Onclick()
    {
        allitemUnActive();
        imageItem1.sprite = item1cl;
        item1Text.SetActive(true);
      
    }

    public void item2Onclick()
    {
        allitemUnActive();
        imageItem2.sprite = item1c2;
        item2Text.SetActive(true);
      
    }

    public void allitemUnActive()
    {
        imageHint1.sprite = h1;
        imageHint2.sprite = h2;
        imageAns.sprite = an;
        imageItem1.sprite = it1;
        imageItem2.sprite = it2;
        hint1Text.SetActive(false);
        hint2Text.SetActive(false);
        ansText.SetActive(false);
        item1Text.SetActive(false);
        item2Text.SetActive(false);
        hintbtn1.SetActive(false);
        hintbtn2.SetActive(false);
        hintbtn3.SetActive(false);
        
    }
    public void Update()
    {
        if (didgetReward)
        {
            afterReward1();
            didgetReward = false;
        }
        if (didgetReward2)
        {
            afterReward2();
            didgetReward2 = false;
        }
        if (didgetReward3)
        {
            afterReward3();
            didgetReward3 = false;
        }
    }

    public void adOnclick1()
    {
        AdmonReward.instance.ShowRewardedAd();
    }

    public void GetRewardTF1(bool tf)
    {
        didgetReward = tf;
    }

    public void afterReward1()
    {
        writer.Write(stagenum+"1", true);
         writer.Commit();
        hintbtn1.SetActive(false);
        hint1Text.SetActive(true);
        hint2.SetActive(true);
    }

    public void adOnclick2()
    {
        AdmonReward.instance.ShowRewardedAd2();
        
    }
    public void GetRewardTF2(bool tf)
    {
        didgetReward2 = tf;
    }

    public void afterReward2()
    {
        writer.Write(stagenum + "2", true);
        writer.Commit();
        hintbtn2.SetActive(false);
        hint2Text.SetActive(true);
        ans.SetActive(true);
    }
    public void adOnclick3()
    {
        AdmonReward.instance.ShowRewardedAd3();
    }
    public void GetRewardTF3(bool tf)
    {
        didgetReward3 = tf;
    }
    public void afterReward3()
    {// データを書き込む
        writer.Write(stagenum + "3", true);

        // 変更を反映
        writer.Commit();
        hintbtn3.SetActive(false);
        
        ansText.SetActive(true);
    }
}
