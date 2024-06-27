using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public List<AudioClip> musics;
    public int currentClip = 0;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(Play(1));
    }

    public IEnumerator Play(float sec)
    {
        yield return new WaitForSeconds(sec);
        audioSource.clip = musics[currentClip];
        audioSource.Play();
        currentClip++;
        if (currentClip >= musics.Count)
        {
            currentClip = 0;
        }
        StartCoroutine(Play(audioSource.clip.length));
    }
}
