using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            if (saves.openResults.results[num])
            {
                buttonCover.SetActive(false);
            }
            num++;
        }
    }
}
