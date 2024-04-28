using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using CI.QuickSave;
using CI.QuickSave.Core.Storage;
using System.IO;


public class GameManage : MonoBehaviour
{
    public static GameManage instance;
 
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;

    bool stage1,stage2,stage3,stage4, stage5, stage6, stage7;
    bool stage;

    QuickSaveSettings settings;
    QuickSaveWriter writer;
    string[] stages = { "Scene1", "Scene2", "Scene3", "Scene4", "Scene5", "Scene6",
    "Scene7","Scene8"};
    public int seneNum = 0;
  

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void Start()
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
        if (File.Exists(fileName))
        {
            return;
        }
        else
        {
            writer.Commit();
        }
        

    }

    /// セーブデータ読み込み
    public bool LoadStage1Data()
    {
        // QuickSaveReaderのインスタンスを作成
        QuickSaveReader reader = QuickSaveReader.Create("SaveStageData", settings);
        //stageは中身なくていい

        if (reader.TryRead<bool>("stage1", out stage)== false)
        {
            stage1 = false;
        }
        else
        {
            stage1 = reader.Read<bool>("stage1");
        }
        return stage1;        
    }
    public bool LoadStage2Data()
    {
        QuickSaveReader reader = QuickSaveReader.Create("SaveStageData", settings);
        if (reader.TryRead<bool>("stage2", out stage) == false)
        {
            stage2 = false;
        }
        else
        {
            stage2 = reader.Read<bool>("stage2");
        }
        return stage2;
    }
    public bool LoadStage3Data()
    {
        QuickSaveReader reader = QuickSaveReader.Create("SaveStageData", settings);
        if (reader.TryRead<bool>("stage3", out stage) == false)
        {
            stage3 = false;
        }
        else
        {
            stage3 = reader.Read<bool>("stage3");
        }
        return stage3;
    }
    public bool LoadStage4Data()
    {
        QuickSaveReader reader = QuickSaveReader.Create("SaveStageData", settings);
        if (reader.TryRead<bool>("stage4", out stage) == false)
        {
            stage4 = false;
        }
        else
        {
            stage4 = reader.Read<bool>("stage4");
        }
        return stage4;
    }
    public bool LoadStage5Data()
    {
        QuickSaveReader reader = QuickSaveReader.Create("SaveStageData", settings);
        if (reader.TryRead<bool>("stage5", out stage) == false)
        {
            stage5 = false;
        }
        else
        {
            stage5 = reader.Read<bool>("stage5");
        }
        return stage5;
    }
    public bool LoadStage6Data()
    {
        QuickSaveReader reader = QuickSaveReader.Create("SaveStageData", settings);
        if (reader.TryRead<bool>("stage6", out stage) == false)
        {
            stage6 = false;
        }
        else
        {
            stage6 = reader.Read<bool>("stage6");
        }
        return stage6;
    }
    public bool LoadStage7Data()
    {
        QuickSaveReader reader = QuickSaveReader.Create("SaveStageData", settings);
        if (reader.TryRead<bool>("stage7", out stage) == false)
        {
            stage7 = false;
        }
        else
        {
            stage7 = reader.Read<bool>("stage7");
        }
        return stage7;
    }

    /// データセーブ
    public void SaveUserData1()
    {
        // データを書き込む
        writer.Write("stage1", true);

        // 変更を反映
        writer.Commit();
    }
    public void SaveUserData2()
    {
       writer.Write("stage2", true);
        writer.Commit();
    }
    public void SaveUserData3()
    {
        writer.Write("stage3", true);
        writer.Commit();
    }
    public void SaveUserData4()
    {
        writer.Write("stage4", true);
        writer.Commit();
    }
    public void SaveUserData5()
    {
        writer.Write("stage5", true);
        writer.Commit();
    }
    public void SaveUserData6()
    {
        writer.Write("stage6", true);
        writer.Commit();
    }
    public void SaveUserData7()
    {
        writer.Write("stage7", true);
        writer.Commit();
    }


    public void ChangeScene(string sceneName)
    {
        Initiate.Fade(sceneName, fadeColor, fadeSpeedMultiplier);
    }

 
    public void GoNextStage()
    {
  
        Initiate.Fade(stages[seneNum], fadeColor, fadeSpeedMultiplier);
    }

    public void GoNextStageAdclose()
    {

        Initiate.Fade(stages[seneNum], fadeColor, fadeSpeedMultiplier);
        AdmobBanner.instance.DestroyBannerView();
    }
    public void GoTitle()
    {
        Initiate.Fade("Title", fadeColor, fadeSpeedMultiplier);
    }

    public void GoStageSelect()
    {
        Initiate.Fade("stageSelect", fadeColor, fadeSpeedMultiplier);
    }
    public void GoStageSelectAdclose()
    {
        Initiate.Fade("stageSelect", fadeColor, fadeSpeedMultiplier);
        AdmobBanner.instance.DestroyBannerView();
    }
    public void GoMenu()
    {
        Initiate.Fade("Menu", fadeColor, fadeSpeedMultiplier);
    }
    public void Thank1()
    {
        Initiate.Fade("thanks01", fadeColor, fadeSpeedMultiplier);
    }

    public void Thank2()
    {
        Initiate.Fade("thanks02", fadeColor, fadeSpeedMultiplier);
    }

    public void ChangeSceneed1()
    {
        Initiate.Fade("Scene8ed1", Color.black, 1.0f);
    }
    public void ChangeSceneed2()
    {
        Initiate.Fade("Scene8ed2", Color.black, 1.0f);
    }
    public void ChangeSceneed3()
    {
        Initiate.Fade("Scene8ed3", Color.black, 1.0f);
    }
    public void GoStage0()
    {
        Initiate.Fade("Scene0", fadeColor, fadeSpeedMultiplier);
    }
    public void GoStage1()
    {
        Initiate.Fade("Scene1", fadeColor, fadeSpeedMultiplier);
    }
    public void GoStage2()
    {
        Initiate.Fade("Scene2", fadeColor, fadeSpeedMultiplier);
    }
    public void GoStage3()
    {
        Initiate.Fade("Scene3", fadeColor, fadeSpeedMultiplier);
    }
    public void GoStage4()
    {
        Initiate.Fade("Scene4", fadeColor, fadeSpeedMultiplier);
    }
    public void GoStage5()
    {
        Initiate.Fade("Scene5", fadeColor, fadeSpeedMultiplier);
    }
    public void GoStage6()
    {
        Initiate.Fade("Scene6", fadeColor, fadeSpeedMultiplier);
    }
    public void GoStage7()
    {
        Initiate.Fade("Scene7", fadeColor, fadeSpeedMultiplier);
    }
    public void GoStage8()
    {
        Initiate.Fade("Scene8", fadeColor, fadeSpeedMultiplier);
    }

    public int returnNum()
    {
        return seneNum;
    }
    public void HideBlock()
    {
        BlockBG.instance.HideBlock();
    }
    public void ShowBlock()
    {
        BlockBG.instance.ShowBlock();
    }


}
