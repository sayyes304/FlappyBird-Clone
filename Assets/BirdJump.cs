using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // 마우스 왼쪽 버튼
        {
            rb.velocity = Vector2.up * jumpPower;   // 2차원 (0,1) * jumpPower
        }
    }
}
