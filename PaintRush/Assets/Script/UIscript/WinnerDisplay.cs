using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerDisplay : MonoBehaviour
{
    List<int> ScoreList;
    string GetMax()
    {
        Vector4 scores = SplatManagerSystem.instance.scores + new Vector4(0.001f, 0.001f, 0.001f, 0.001f);
        int yelowScore = (int)scores.x;
        int redScore = (int)scores.y;
        int greenScore = (int)scores.z;
        int blueScore = (int)scores.w;
        ScoreList = new List<int>();
        ScoreList.Add(yelowScore);
        ScoreList.Add(redScore);
        ScoreList.Add(greenScore);
        ScoreList.Add(blueScore);
        
        if (yelowScore > greenScore)
        {
          return "Player 1";
        }
        else
        {
            return "Player 2";
        }
        
    }

    
    void Update()
    {
        Text winner = GetComponent<Text>();
        winner.text = "Winner " + GetMax();
    }
}
