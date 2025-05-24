using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveInput : MonoBehaviour
{
    public float moveSpeed = 5;
    public Rigidbody2D rigid;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        rigid.velocity = new Vector2(moveSpeed * h, 0);
    }
}
