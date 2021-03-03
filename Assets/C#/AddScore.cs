using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class AddScore : MonoBehaviour
{
    public GameObject monster;
    public Text score;
    public static int Score;
    public static bool mons=false;
    public static bool Onpaused = false;
    public GameObject onPaused;
    public Text BestScore;
    void Update()
    {       score.text = "" + Score;
       
            if (Score >= 2 && mons == false)

            {

                Instantiate(monster);
                mons = true;
            }
        
        if (Score >= 2 && Onpaused == false)
        {
            Time.timeScale = 1.3f;
        }
        if (Score >= 40 && Onpaused == false)
        {
            Time.timeScale = 1.6f;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Onpaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }


        }
      

    }

    void Resume()
    {
        onPaused.SetActive(false);
        Time.timeScale = 1f;
        Onpaused = false;


    }

    public void Pause()
    {
        onPaused.SetActive(true);
        Time.timeScale = 0f;
        Onpaused = true;
        BestScore.text = "Yours best score:" + Doodle.highScore;



    }
    public void ReturenInGame()
    {
        onPaused.SetActive(false);
        Time.timeScale = 1f;
        Onpaused = false;

    }
    public void SceneLoad(int index)
    {
        onPaused.SetActive(false); 
        Time.timeScale = 1f;
        Onpaused = false;
        SceneManager.LoadScene(index);
    }



}
