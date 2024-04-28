using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine;

public class AdInitialize : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            // This callback is called once the MobileAds SDK is initialized.
        });
    }
    
}
