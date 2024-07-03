using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class Saves : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenResult(int resultId)
    {
        YandexGame.savesData.openVariants[resultId-1] = true;
        YandexGame.SaveProgress();
        //openResults.SaveResult(resultId, true);
        //var stringResults = openResults.GetStringResults();
        //PlayerPrefs.SetString("OpenResults", stringResults);
    }
}
