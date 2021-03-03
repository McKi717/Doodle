using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayLoadScene1 : MonoBehaviour
{
    public AudioSource music;  
    public void SceneLoad(int index)
    {
        SceneManager.LoadScene(index);
        AddScore.mons = false;
        
    }
    public void StartPauseMusic()
    {
        
        if (music.isPlaying)
            music.Stop();
        else
            music.Play();


    }
}


