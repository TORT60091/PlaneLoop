using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public static CanvasScript instance;
    public GameObject gameOverText;
    public GameObject gameOverButton;
    // Start is called before the first frame update
    void Start()
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

    public void ShowGameOver()
    {
        gameOverText.SetActive(true);
        gameOverButton.SetActive(true);
    }
    // Update is called once per frame

    public void HideAll()
    {
        gameOverText.SetActive(false);
        gameOverButton.SetActive(false);

    }
   
}
