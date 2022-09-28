using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sliderValue : MonoBehaviour
{
    public Slider slider;
    public Text text;
    public float valuePlayers;
    public Button startGame;
    public Button exitGame;

    void Start()
    {
        startGame.onClick.AddListener(StartGame);
        exitGame.onClick.AddListener(ExitGame);
    }

    void Update()
    {
        valuePlayers = slider.value;
        text.text = valuePlayers.ToString();
        
    }
        
    public void StartGame()
    {
        GlobalP.valuePlayers = valuePlayers;
        SceneManager.LoadScene("Level1");
    }
    void ExitGame()
    {
        Application.Quit();
    }

}
