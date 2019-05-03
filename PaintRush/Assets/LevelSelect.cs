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
        SceneManager.LoadScene("GameLevel3");
    }
    public void Level4()
    {
        SplatManagerSystem.instance.m_RendererAray = new List<List<Renderer>>();
        SplatManagerSystem.instance.m_Renderers = new List<Renderer>();
        SplatManagerSystem.instance.m_Splats = new List<Splat>();
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameLevel4");
    }
    public void Level5()
    {
        SplatManagerSystem.instance.m_RendererAray = new List<List<Renderer>>();
        SplatManagerSystem.instance.m_Renderers = new List<Renderer>();
        SplatManagerSystem.instance.m_Splats = new List<Splat>();
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameLevel5");
    }
    public void Level6()
    {
        SplatManagerSystem.instance.m_RendererAray = new List<List<Renderer>>();
        SplatManagerSystem.instance.m_Renderers = new List<Renderer>();
        SplatManagerSystem.instance.m_Splats = new List<Splat>();
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameLevel6");
    }
    public void Level7()
    {
        SplatManagerSystem.instance.m_RendererAray = new List<List<Renderer>>();
        SplatManagerSystem.instance.m_Renderers = new List<Renderer>();
        SplatManagerSystem.instance.m_Splats = new List<Splat>();
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameLevel7");
    }
    public void Level8()
    {
        SplatManagerSystem.instance.m_RendererAray = new List<List<Renderer>>();
        SplatManagerSystem.instance.m_Renderers = new List<Renderer>();
        SplatManagerSystem.instance.m_Splats = new List<Splat>();
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameLevel8");
    }
}
