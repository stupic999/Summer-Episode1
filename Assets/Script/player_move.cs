using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour {

    private Rigidbody rb;
    public float spd=100;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        // 按鈕
        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(HorizontalMovement, 0f, VerticalMovement);

        rb.AddForce(movement*spd);
    }
}
