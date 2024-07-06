using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordinate : MonoBehaviour
{
    const float diff = 17.5f;
    public GameObject coordinateDot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCoordinate(int rus, int heroism)
    {
        float diffScreen = (Screen.width / 1920f) * diff;
        var newPosition = new Vector3(rus * diffScreen, heroism * diffScreen, 0);
        coordinateDot.transform.localPosition = newPosition;
    }
}
