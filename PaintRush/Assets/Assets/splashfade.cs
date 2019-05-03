using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class splashfade : MonoBehaviour
{
    public Image splashimage;
    public string loadLevel;
IEnumerator Start()
    {
        splashimage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(2.5f);
        FadeOut();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(loadLevel);
    }
    void FadeIn()
    {
        splashimage.CrossFadeAlpha(1.0f, 1.5f, false);
    }
    void FadeOut()
    {
        splashimage.CrossFadeAlpha(0.0f, 1.5f, false);
    }

}
