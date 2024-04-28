using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using System.IO;

public class AdmonInter : MonoBehaviour
{
    private InterstitialAd interstitial;
    //public string _adUnitId = "ca-app-pub-3940256099942544/1033173712";testdayo
    //–{”Ô—p
    public string _adUnitId = "ca-app-pub-7532687517474511/7972822697";
    InterstitialAd interstitialAd;

    public static AdmonInter instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void Start()
    {
        LoadInterstitialAd();
    }
    // These ad units are configured to always serve test ads.


    public void LoadInterstitialAd()
    {
        // Clean up the old ad before loading a new one.
        if (interstitialAd != null)
        {
            interstitialAd.Destroy();
            interstitialAd = null;
        }

        Debug.Log("Loading the interstitial ad.");

        // create our request used to load the ad.
        var adRequest = new AdRequest();

        // send the request to load the ad.
        InterstitialAd.Load(_adUnitId, adRequest,
            (InterstitialAd ad, LoadAdError error) =>
            {
              // if error is not null, the load request failed.
              if (error != null || ad == null)
                {
                    Debug.LogError("interstitial ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }

                Debug.Log("Interstitial ad loaded with response : "
                          + ad.GetResponseInfo());

                interstitialAd = ad;
                //RegisterEventHandlers(interstitialAd);
            });
    }

    public void ShowInterstitialAd()
    {
        if (interstitialAd != null && interstitialAd.CanShowAd())
        {
            Debug.Log("Showing interstitial ad.");
            interstitialAd.Show();
        }
        else
        {
            Debug.LogError("Interstitial ad is not ready yet.");
        }
    }
    private void RegisterEventHandlers(InterstitialAd interstitialAd)
    {
        // Raised when the ad is estimated to have earned money.
        interstitialAd.OnAdPaid += (AdValue adValue) =>
        {
            Debug.Log(String.Format("Interstitial ad paid {0} {1}.",
                adValue.Value,
                adValue.CurrencyCode));
        };
        // Raised when an impression is recorded for an ad.
        interstitialAd.OnAdImpressionRecorded += () =>
        {
            Debug.Log("Interstitial ad recorded an impression.");
        };
        // Raised when a click is recorded for an ad.
        interstitialAd.OnAdClicked += () =>
        {
            Debug.Log("Interstitial ad was clicked.");
        };
        // Raised when an ad opened full screen content.
        interstitialAd.OnAdFullScreenContentOpened += () =>
        {
            Debug.Log("Interstitial ad full screen content opened.");
        };
        // Raised when the ad closed full screen content.
        interstitialAd.OnAdFullScreenContentClosed += () =>
        {
            Debug.Log("Interstitial ad full screen content closed.");
        };
        // Raised when the ad failed to open full screen content.
        interstitialAd.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Debug.LogError("Interstitial ad failed to open full screen content " +
                           "with error : " + error);
        };
    }
    public void DestroyInterstitialAd()
    {
        interstitialAd.Destroy();
    }
}
