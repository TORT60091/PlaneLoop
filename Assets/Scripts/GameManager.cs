using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public static GameManager instance;
    public bool isGameOver;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(this);
    }
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    public void RestartGame()
    {
        CanvasScript.instance.HideAll();
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        isGameOver = true;
        CanvasScript.instance.ShowGameOver();
    }

    
}
