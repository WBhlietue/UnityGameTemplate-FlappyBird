using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public Rigidbody2D rb;
    public Collider2D coll;
    public float moveSpeed;
    public float jumpForce;
    GameManager gameManager;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gameManager = GameManager.instance;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameManager.gameState == GameState.Start)
            {
                gameManager.GameStart();
            }
            Jump();
        }
        Move();
    }

    void Jump()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * jumpForce);
    }

    void Move()
    {
        if (gameManager.gameState == GameState.Playing)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}
