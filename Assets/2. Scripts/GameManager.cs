using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState gameState;
    Player player;
    PipeManager pipeManager;

    public GameObject gameOverPanel;
    public GameObject startMenu;
    int _score = 0;
    int score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            t.text = value.ToString();
        }
    }
    public Text t;
    private void Awake()
    {
        instance = this;
        gameState = GameState.Start;
    }

    private void Start()
    {
        player = Player.instance;
        pipeManager = PipeManager.instance;
        player.rb.Sleep();
        score = 0;
    }

    public void Fail()
    {
        gameState = GameState.End;
        Debug.Log("fail");
        gameOverPanel.SetActive(true);
    }

    public void GameStart()
    {
        gameState = GameState.Playing;
        player.rb.WakeUp();
        startMenu.SetActive(false);
    }

    public void AddScore()
    {
        score++;
        pipeManager.Spawn();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

public enum GameState
{
    Start, Playing, End
}
