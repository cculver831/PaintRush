using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerButtons : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject PlayerUI;
    public void PlayAgain()
    {
        SplatManagerSystem.instance.m_RendererAray = new List<List<Renderer>>();
        SplatManagerSystem.instance.m_Renderers = new List<Renderer>();
        SplatManagerSystem.instance.m_Splats = new List<Splat>();
        SceneManager.LoadScene("GameLevel");
    }
    public void LoadMenu()
    {
     SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
