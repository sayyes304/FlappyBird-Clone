using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower;   // 2차원 (0,1) * jumpPower
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
