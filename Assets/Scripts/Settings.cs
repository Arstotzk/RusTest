using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider slider;
    public AudioMixer audioMixer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetMusicValue()
    {
        var value = PlayerPrefs.GetFloat("Music", 0.8f);
        audioMixer.SetFloat("Music", Mathf.Log10(value) * 20);
        slider.value = value;
    }
    public void MusicValueChanged()
    {
        var value = slider.value;
        if (value == 0)
            value = 0.0001f;
        audioMixer.SetFloat("Music", Mathf.Log10(value) * 20);
        float test = 0f;
        audioMixer.GetFloat("Music", out test);
        PlayerPrefs.SetFloat("Music", value);
    }
}
