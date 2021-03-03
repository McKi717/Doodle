using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Platform : MonoBehaviour
{
    public AudioSource audioJump;
    public float ForceJump;

    private void OnCollisionEnter2D(Collision2D collision)

    {
        
        if (collision.relativeVelocity.y < 0)
        {   Jump();
            audioJump.Play();
            AddScore.Score += 1;
        }
       
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "TriggerDead")
        {
            float RandomX = Random.Range(-1.7f, 1.7f);
            float RandomY = Random.Range(transform.position.y + 19f, transform.position.y + 20f);
            transform.position = new Vector3(RandomX, RandomY, 0);

        }
    }
    private void Jump()
    { 
        Doodle.doodle.rigidbody2D.velocity = Vector2.up * ForceJump;

    }
}
