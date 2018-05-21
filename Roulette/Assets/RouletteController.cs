using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RouletteController : MonoBehaviour
{

    float rotSpeed;

    //回転しているかどうかの判断
    bool isTurn = false;
	
	// Update is called once per frame
	void Update ()
    {
        //連続で加速しないようにした
        if (Input.GetMouseButtonDown(0) && isTurn == false)
        {
            rotSpeed = 10;
            isTurn = true;
        }

        //完全に停止する処理
        if(rotSpeed<=0.1f)
        {
            rotSpeed = 0;
            isTurn = false;
        }

        //回転と速度減衰の処理
        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= Random.Range(0.90f, 0.99f);
	}
}
