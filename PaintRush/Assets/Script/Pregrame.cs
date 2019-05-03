using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pregrame : MonoBehaviour
{
    [SerializeField] private Text uiText;
    public GameObject Pregame;
    public GameObject PlayerUI;

    IEnumerator Timer()
    {
        Time.timeScale = 0.0f;
        Debug.Log("Ready.... Set... Go!");
        yield return new WaitForSeconds(2);
        Pregame.SetActive(false);
        PlayerUI.SetActive(true);
    }
}

