using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeeperMove : MonoBehaviour
{
    int counter = 0;
    float move = 0.02f;

    void Update()
    {

        transform.Translate(new Vector3(move * Time.deltaTime, 0, 0));
        counter++;


        //countが500になれば-1を掛けて逆方向に動かす
        if (counter == 240)
        {
            counter = 0;
            move *= -1;
        }
    }
}
