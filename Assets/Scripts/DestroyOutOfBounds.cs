using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public static DestroyOutOfBounds instance;
    private float leftLimit = 0.5f;
    private float rightLimit = 11.0f;
    private float bottomLimit = 19.5f;
    private float topLimit = 0.1f;
//    public bool judgement;


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        if (transform.position.x < -leftLimit)
        {
            Destroy(gameObject);
//            judgement = false;
        }
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.x > rightLimit)
        { 
            Destroy(gameObject);
//            judgement = false;
        }
        else if (transform.position.z < -bottomLimit)
        {
            Destroy(gameObject);
//            judgement = false;
        }
        else if (transform.position.z > topLimit)
        {
            Destroy(gameObject);
//            judgement = false;
        }

    }
}
