using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 0.1f;
    private Rigidbody rb;
    public float upForce = 2000f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var velox = speed * Input.GetAxisRaw("Horizontal");
        rb.AddForce(new Vector3(velox * 0.3f, 0f, 0f));


        if(Input.GetKeyDown("space"))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(new Vector3(0f, upForce, 0f));
    }

}

