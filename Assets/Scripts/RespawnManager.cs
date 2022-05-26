using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{

    public GameObject ballPrefabs;


    void Update()
    {
        GameObject ballObj = GameObject.Find("SoccerBall");
        if (ballObj == null)
        {
            ///DestroyOutOfBounds.instance.judgement = true;
            GameObject newBall = Instantiate(ballPrefabs);
            newBall.name = ballPrefabs.name;

        }
    }

    
    /*void RespawnBall()
    {
        //Vector3 spawnPos = new Vector3(5, 0, -5);
        
        //Instantiate(ball, spawnPos, transform.rotation);
    }*/
}
