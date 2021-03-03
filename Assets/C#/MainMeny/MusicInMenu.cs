using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInMenu : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad (this.audioSource);
        GameObject[] music = GameObject.FindGameObjectsWithTag("MusicMain");
        if (music.Length > 1)
        {
            Destroy(this.gameObject);
        }
    }


}
