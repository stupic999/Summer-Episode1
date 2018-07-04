using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_score : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 隨機cube位置
        float x1 = UnityEngine.Random.Range(-9.0f, 9.0f);
        float z1 = UnityEngine.Random.Range(-9.0f, 9.0f);
        transform.position= new Vector3(x1,1f,z1);
    }
	
	// Update is called once per frame
	void Update () {
        // 自身旋轉
        transform.Rotate(0.3f,0.3f,0.3f);
    }

    private void OnTriggerEnter(Collider collider)
    {
        // 碰撞
        if (collider.name == "Player")
        {
            Destroy(gameObject);
            score.Score += 1;
        }

    }
}
