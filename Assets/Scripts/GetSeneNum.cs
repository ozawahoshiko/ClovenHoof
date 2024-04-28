using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetSeneNum : MonoBehaviour
{
    public int seneNum =0;

    string[] stages = { "Scene1", "Scene2", "Scene3", "Scene4", "Scene5", "Scene6","Scene7","Scene8"};
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 1.0f;
    void Start()
    {
        Debug.Log("Sene–¼‚Í‚Ë‚¦‚¥" + seneNum);
    }
    public void GoNextStage()
    {
        seneNum++;
        Initiate.Fade(stages[seneNum], fadeColor, fadeSpeedMultiplier);
    }

}
