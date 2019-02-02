using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("GameLevel");
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
