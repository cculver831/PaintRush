using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool levelSelect = false;
    public GameObject levelS;
    public GameObject Main;
    public static bool MainM = true;
    public void Play()
    {
        levelSelect = true;
        levelS.SetActive(true);
        Main.SetActive(false);
        MainM = false;
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
