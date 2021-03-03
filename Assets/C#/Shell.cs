using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public float speed;
    new Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0f, speed);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
        }
    
    
        if (collision.gameObject.CompareTag("Monster"))
            {
            Destroy(this.gameObject);
            float X = Random.Range(2f, 2f);
            collision.gameObject.transform.position = new Vector2(X, 40);
            AddScore.Score += 5;
            
        }

    }
}