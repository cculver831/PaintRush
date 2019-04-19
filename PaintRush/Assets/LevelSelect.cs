using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Level1()
    {
        SplatManagerSystem.instance.m_RendererAray = new List<List<Renderer>>();
        SplatManagerSystem.instance.m_Renderers = new List<Renderer>();
        SplatManagerSystem.instance.m_Splats = new List<Splat>();
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameLevel");
    }
    public void Level2()
    {
        SplatManagerSystem.instance.m_RendererAray = new List<List<Renderer>>();
        SplatManagerSystem.instance.m_Renderers = new List<Renderer>();
        SplatManagerSystem.instance.m_Splats = new List<Splat>();
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameLevel2");
    }
    public void Level3()
    {
        SplatManagerSystem.instance.m_RendererAray = new List<List<Renderer>>();
        SplatManagerSystem.instance.m_Renderers = new List<Renderer>();
        SplatManagerSystem.instance.m_Splats = new List<Splat>();
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameLevel4");
    }

}
