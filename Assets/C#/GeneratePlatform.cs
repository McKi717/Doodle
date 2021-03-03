using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
    public GameObject prePlatform;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition =new  Vector3();
        for(int i=0; i<6; i++)
        {
            spawnPosition.x = Random.Range(-2f, 2f);
            spawnPosition.y += Random.Range(2f, 4f);
            Instantiate(prePlatform, spawnPosition, Quaternion.identity);
        }
        
        
    }


}
