using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayerMove2 : MonoBehaviour
{
    int counter = 0;
    float move = 0.01f;

    void Update()
    {

        transform.Translate(new Vector3(move, 0, 0));
        counter++;


        //count��100�ɂȂ��-1���|���ċt�����ɓ�����
        if (counter == 100)
        {
            counter = 0;
            move *= -1;
        }
    }
}
