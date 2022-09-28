using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button menuButton;

    void Start()
    {
        menuButton.onClick.AddListener(GoToMenu);
    }

    void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
