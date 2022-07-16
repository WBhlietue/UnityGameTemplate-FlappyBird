using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    GameManager gameManager;
    private void Start() {
        gameManager = GameManager.instance;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            gameManager.Fail();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Complete"))
        {
            Debug.Log("complete");
            gameManager.AddScore();
        }
    }
}
