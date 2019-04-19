using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("GameLevel");
    }
    public void Level2()
    {
        SceneManager.LoadScene("GameLevel2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("GameLevel4");
    }

}
