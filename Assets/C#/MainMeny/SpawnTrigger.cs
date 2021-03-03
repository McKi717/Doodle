using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Monster")
        {
       
            
                collision.transform.position = new Vector2(0, 20);
            
        }
    }
}
