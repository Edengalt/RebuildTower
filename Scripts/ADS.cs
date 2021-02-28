using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class ADS : MonoBehaviour
{

    private Coroutine ShowAds;
    private string gameId = "3863585", type = "video";
    private bool testmode = false, needToStop;

    private static int countLoses;

    private void Start()
    {
        Advertisement.Initialize(gameId, testmode);
        countLoses++;
        if(countLoses %5 == 0)
            ShowAds = StartCoroutine(showAds());  
     }

    private void Update()
    {
        if(needToStop)
        {
            
            needToStop = false;
            StopCoroutine(ShowAds);
        }
       
    }


    IEnumerator showAds()
    {
        while (true)
        {
            if(Advertisement.IsReady(type))
            {
                Advertisement.Show(type);
                needToStop = true;
                
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
