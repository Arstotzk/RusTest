using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class SetOpenResults : MonoBehaviour
{
    public Saves saves;
    public List<GameObject> buttonsCover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetResults() 
    {
        var num = 0;
        foreach (var buttonCover in buttonsCover)
        {
            if (YandexGame.savesData.openVariants[num])
            {
                buttonCover.SetActive(false);
            }
            num++;
        }
    }
}
