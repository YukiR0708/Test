using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayerMove : MonoBehaviour
{
    int counter = 0;
    float move = 0.01f;

    void Update()
    {

        transform.Translate(new Vector3(0, 0, move));
        counter++;


        //count��200�ɂȂ��-1���|���ċt�����ɓ�����
        if (counter == 200)
        {
            counter = 0;
            move *= -1;
        }
    }
}
