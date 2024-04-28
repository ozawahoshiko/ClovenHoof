using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;

public class AdmonReward : MonoBehaviour
{
    RewardedAd rewardedAd;
    //private string _adUnitId = "ca-app-pub-3940256099942544/5224354917"; testdayo
    //–{”Ô—p
    private string _adUnitId = "ca-app-pub-7532687517474511/1198411220";
    public hintmenu hintmenu ;

    public static AdmonReward instance;



   // public GameObject hint2, hintbtn1, hint1Text;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            LoadRewardedAd();
        });
    }


    public void LoadRewardedAd()
    {

        // Clean up banner ad before creating a new one.
        if (rewardedAd != null)
        {
            rewardedAd.Destroy();
            rewardedAd = null;
        }

        Debug.Log("Loading the rewarded ad.");

        // create our request used to load the ad.
        var adRequest = new AdRequest();

        // send the request to load the ad.
        RewardedAd.Load(_adUnitId, adRequest,
            (RewardedAd ad, LoadAdError error) =>
            {
              // if error is not null, the load request failed.
              if (error != null || ad == null)
                {
                    Debug.LogError("Rewarded ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }

                Debug.Log("Rewarded ad loaded with response : "
                          + ad.GetResponseInfo());

                rewardedAd = ad;
                RegisterReloadHandler(rewardedAd);
                //RegisterEventHandlers(rewardedAd);
            });
    }
    
    public void ShowRewardedAd()
    {
        //const string rewardMsg ="Rewarded ad rewarded the user. Type: {0}, amount: {1}.";

        if (rewardedAd != null && rewardedAd.CanShowAd())
        {
            rewardedAd.Show((Reward reward) =>
            {   
                    hintmenu.GetRewardTF1(true);
                });
        }
        rewardedAd.Destroy();
    }
    public void ShowRewardedAd2()
    {
       
        if (rewardedAd != null && rewardedAd.CanShowAd())
        {
            rewardedAd.Show((Reward reward) =>
            {
                hintmenu.GetRewardTF2(true);
            });
        }
        rewardedAd.Destroy();
    }
    public void ShowRewardedAd3()
    {
        if (rewardedAd != null && rewardedAd.CanShowAd())
        {
            rewardedAd.Show((Reward reward) =>
            {
                hintmenu.GetRewardTF3(true);
            });
        }
        rewardedAd.Destroy();
    }

    public void ShowRewardedAd68()
    {
        //const string rewardMsg ="Rewarded ad rewarded the user. Type: {0}, amount: {1}.";

        if (rewardedAd != null && rewardedAd.CanShowAd())
        {
            rewardedAd.Show((Reward reward) =>
            {
                hintmenu68.instance.GetRewardTF1(true);
            });
        }
        rewardedAd.Destroy();
    }

    public void ShowRewardedAd368()
    {
        if (rewardedAd != null && rewardedAd.CanShowAd())
        {
            rewardedAd.Show((Reward reward) =>
            {
                hintmenu68.instance.GetRewardTF3(true);
            });
        }
        rewardedAd.Destroy();
    }

    private void RegisterEventHandlers(RewardedAd ad)
    {
        // Raised when the ad is estimated to have earned money.
        ad.OnAdPaid += (AdValue adValue) =>
        {
            Debug.Log(String.Format("Rewarded ad paid {0} {1}.",
                adValue.Value,
                adValue.CurrencyCode));
        };
        // Raised when an impression is recorded for an ad.
        ad.OnAdImpressionRecorded += () =>
        {
            Debug.Log("Rewarded ad recorded an impression.");
        };
        // Raised when a click is recorded for an ad.
        ad.OnAdClicked += () =>
        {
            Debug.Log("Rewarded ad was clicked.");
        };
        // Raised when an ad opened full screen content.
        ad.OnAdFullScreenContentOpened += () =>
        {
            Debug.Log("Rewarded ad full screen content opened.");
        };
        // Raised when the ad closed full screen content.
        ad.OnAdFullScreenContentClosed += () =>
        {
            Debug.Log("Rewarded ad full screen content closed.");
        };
        // Raised when the ad failed to open full screen content.
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Debug.LogError("Rewarded ad failed to open full screen content " +
                           "with error : " + error);
        };
    }
    private void RegisterReloadHandler(RewardedAd ad)
    {
        // Raised when the ad closed full screen content.
        ad.OnAdFullScreenContentClosed += () =>
        {
            Debug.Log("Rewarded Ad full screen content closed.");

            // Reload the ad so that we can show another as soon as possible.
            LoadRewardedAd();
        };
        // Raised when the ad failed to open full screen content.
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Debug.LogError("Rewarded ad failed to open full screen content " +
                           "with error : " + error);

            // Reload the ad so that we can show another as soon as possible.
            LoadRewardedAd();
        };
    }
}
