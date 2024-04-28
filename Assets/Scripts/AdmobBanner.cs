using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
//MobileAds.RaiseAdEventsOnUnityMainThread = true;

public class AdmobBanner : MonoBehaviour
{
    private BannerView bannerView;

    public static AdmobBanner instance;

    // These ad units are configured to always serve test ads.
#if UNITY_ANDROID
    //private string _adUnitId = "ca-app-pub-3940256099942544/6300978111";
    //–{”Ô—p
    private string _adUnitId = "ca-app-pub-7532687517474511/8154796301";
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
  private string _adUnitId = "unused";
#endif

    BannerView _bannerView;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

 



    /// <summary>
    /// Creates a 320x50 banner view at top of the screen.
    /// </summary>
    public void CreateBannerView()
    {
        

        // If we already have a banner, destroy the old one.
        if (_bannerView != null)
        {
            DestroyBannerView();
        }

        // Create a 320x50 banner at top of the screen
        _bannerView = new BannerView(_adUnitId, AdSize.Banner, AdPosition.Bottom);
    }
    public void CreateBannerView2()
    {


        // If we already have a banner, destroy the old one.
        if (_bannerView != null)
        {
            DestroyBannerView();
        }

        // Create a 320x50 banner at top of the screen
        _bannerView = new BannerView(_adUnitId, AdSize.MediumRectangle, AdPosition.Bottom);
    }
    public void LoadAd()
    {
        // create an instance of a banner view first.
        if (_bannerView == null)
        {
            CreateBannerView();
        }

        // create our request used to load the ad.
        var adRequest = new AdRequest();

        // send the request to load the ad.
      
        _bannerView.LoadAd(adRequest);
    }

    public void LoadAd2()
    {
        // create an instance of a banner view first.
        if (_bannerView == null)
        {
            CreateBannerView2();
        }

        // create our request used to load the ad.
        var adRequest = new AdRequest();

        // send the request to load the ad.

        _bannerView.LoadAd(adRequest);
    }
    public void DestroyBannerView()
    {
        if (_bannerView != null)
        {
           
            _bannerView.Destroy();
            _bannerView = null;
        }
    }
}
