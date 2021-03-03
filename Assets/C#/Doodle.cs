using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Doodle : MonoBehaviour
{
    public AudioSource audioFalls;
    public new Rigidbody2D rigidbody2D;
    private float speed = 3f;
    public static Doodle doodle;
    public GameObject shells;
    private new Animator animation;
    private float timeAround;
    public AudioSource audioShoot;
    public GameObject DeadCamera;
    public Text BestScore;
    public static int highScore;
    

    void Start()
    {

        highScore = PlayerPrefs.GetInt("highScore", 0);
        if (doodle == null)
            doodle = this;
        animation = GetComponent<Animator>();
    }
    private void Update()
    {
        timeAround += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space)&&timeAround>0.8f)
        {
            audioShoot.Play();
            Shell();
            animation.SetBool("Shoot", true);
            timeAround = 0;
        }
        else { animation.SetBool("Shoot", false); }

        if (AddScore.Score > highScore)
        {
            highScore = AddScore.Score;
            PlayerPrefs.SetInt("highScore", highScore);
        }
    }

    void FixedUpdate()
    {
        
        float MoveInput = Input.GetAxisRaw("Horizontal");
        Vector3 Move = new Vector3(MoveInput, 0, 0);
        transform.position += Move * Time.deltaTime * speed;
        if (MoveInput > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (MoveInput < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
       
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "TriggerDead")
        {
            audioFalls.Play();
            DeadCam();
        }
        if (collision.gameObject.tag == "Monster")
        {
            DeadCam();
           
            audioFalls.Play();
          

        }
    }
    public void DeadCam()
    {

        DeadCamera.SetActive(true);
        Time.timeScale = 0f;
        BestScore.text = "Yours best score:" + highScore;
        AddScore.Onpaused = true;
  
    }
     public void Restart(int index)
    {
      DeadCamera.SetActive(false);
        Time.timeScale = 1f;
      AddScore.Onpaused = false;
       SceneManager.LoadScene(index);
       AddScore.Score = 0;
        AddScore.mons = false;
        
    }





    void Shell()
    {
        Vector3 pos = transform.position;
        Instantiate(shells, pos, Quaternion.identity);
    }

}
