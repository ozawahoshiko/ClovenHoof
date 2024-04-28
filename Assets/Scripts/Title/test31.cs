using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CI.QuickSave;
using UnityEngine.UI;
using TMPro;
public class test31 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI KeyText, KeyText2;
    private void Start()
    {
        QuickSaveGlobalSettings.StorageLocation = Application.persistentDataPath;


       // QuickSaveGlobalSettings.StorageLocation = Application.dataPath;
        // QuickSaveSettingsのインスタンスを作成
        QuickSaveSettings settings = new QuickSaveSettings();
        // 暗号化の方法 
        settings.SecurityMode = SecurityMode.None;
        // Aesの暗号化キー
        settings.Password = "Pass";
        // 圧縮の方法
        settings.CompressionMode = CompressionMode.Gzip;
        // QuickSaveWriterのインスタンスを作成
        QuickSaveWriter writer = QuickSaveWriter.Create("Test31", settings);
        // データを書き込む
        writer.Write("Name", "Raiun");

        // 変更を反映
        writer.Commit();
        // QuickSaveReaderのインスタンスを作成



        QuickSaveReader reader = QuickSaveReader.Create("Test31", settings);
        string name = reader.Read<string>("Name");

        KeyText.text = QuickSaveGlobalSettings.StorageLocation;
        KeyText2.text = name;
        

    }
    /*
        private void Staart()
        {
            // QuickSaveGlobalSettings.StorageLocation = Application.dataPath;
            // QuickSaveSettingsのインスタンスを作成
            QuickSaveSettings settings = new QuickSaveSettings();
            // 暗号化の方法 
            settings.SecurityMode = SecurityMode.None;
            // Aesの暗号化キー
            settings.Password = "Pass";
            // 圧縮の方法
            settings.CompressionMode = CompressionMode.Gzip;
            // QuickSaveWriterのインスタンスを作成
            QuickSaveWriter writer = QuickSaveWriter.Create("Test31", settings);
            // データを書き込む
            writer.Write("Name", "Raiun");

            // 変更を反映
            writer.Commit();
            // QuickSaveReaderのインスタンスを作成



            QuickSaveReader reader = QuickSaveReader.Create("Test31", settings);
            string name = reader.Read<string>("Name");

            KeyText.text = name;
            Debug.Log("name: " + name );

        }*/

}
