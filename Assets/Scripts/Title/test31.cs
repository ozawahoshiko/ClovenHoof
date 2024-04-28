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
        // QuickSaveSettings�̃C���X�^���X���쐬
        QuickSaveSettings settings = new QuickSaveSettings();
        // �Í����̕��@ 
        settings.SecurityMode = SecurityMode.None;
        // Aes�̈Í����L�[
        settings.Password = "Pass";
        // ���k�̕��@
        settings.CompressionMode = CompressionMode.Gzip;
        // QuickSaveWriter�̃C���X�^���X���쐬
        QuickSaveWriter writer = QuickSaveWriter.Create("Test31", settings);
        // �f�[�^����������
        writer.Write("Name", "Raiun");

        // �ύX�𔽉f
        writer.Commit();
        // QuickSaveReader�̃C���X�^���X���쐬



        QuickSaveReader reader = QuickSaveReader.Create("Test31", settings);
        string name = reader.Read<string>("Name");

        KeyText.text = QuickSaveGlobalSettings.StorageLocation;
        KeyText2.text = name;
        

    }
    /*
        private void Staart()
        {
            // QuickSaveGlobalSettings.StorageLocation = Application.dataPath;
            // QuickSaveSettings�̃C���X�^���X���쐬
            QuickSaveSettings settings = new QuickSaveSettings();
            // �Í����̕��@ 
            settings.SecurityMode = SecurityMode.None;
            // Aes�̈Í����L�[
            settings.Password = "Pass";
            // ���k�̕��@
            settings.CompressionMode = CompressionMode.Gzip;
            // QuickSaveWriter�̃C���X�^���X���쐬
            QuickSaveWriter writer = QuickSaveWriter.Create("Test31", settings);
            // �f�[�^����������
            writer.Write("Name", "Raiun");

            // �ύX�𔽉f
            writer.Commit();
            // QuickSaveReader�̃C���X�^���X���쐬



            QuickSaveReader reader = QuickSaveReader.Create("Test31", settings);
            string name = reader.Read<string>("Name");

            KeyText.text = name;
            Debug.Log("name: " + name );

        }*/

}
