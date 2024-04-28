using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdmonUserAction : MonoBehaviour
{
    public Text coinCountText;
    public GameObject ConfirmWatchDialogue;
    int coinCount;
    public AdmonRewardtest AM;

    void Start()
    {
        coinCount = 0;    
    }

    public void OnClickReward()
    {
        ConfirmWatchDialogue.SetActive(true);
    }
    public void OnClickConfirmWatch()
    {
        AM.ShowRewardedAd();
    }
    public void OnClickCancelWatch()
    {
        ConfirmWatchDialogue.SetActive(false);
    }
    public void OnUserEarnedReward()
    {
        coinCount += 100;
        coinCountText.text = coinCount.ToString();
        ConfirmWatchDialogue.SetActive(false);
    }
}
