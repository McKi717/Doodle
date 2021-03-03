using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform posDoodle;


    void Update()
    {if (posDoodle.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, posDoodle.position.y, transform.position.z);
        }
        
    }
}
