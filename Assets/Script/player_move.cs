using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour {

    // Update is called once per frame
    void FixedUpdate () {
        // 移動
        if (Input.GetKey("s"))
        {
            GameObject.Find("Player").transform.position += new Vector3(0, 0, -0.5f);
        }
        if (Input.GetKey("a"))
        {
            GameObject.Find("Player").transform.position += new Vector3(-0.5f, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            GameObject.Find("Player").transform.position += new Vector3(0, 0, 0.5f);
        }
        if (Input.GetKey("d"))
        {
            GameObject.Find("Player").transform.position += new Vector3(0.5f, 0,0);
        }
    }
}
