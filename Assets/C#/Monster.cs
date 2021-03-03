using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Monster : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0, -3);
        transform.position = new Vector2(0, 25);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "TriggerDead")
        {
            float RandomX = Random.Range(-2f, 2f);
            float Y = (transform.position.y + 20f);
            transform.position = new Vector3(RandomX, Y, 0);

        }


    }

}