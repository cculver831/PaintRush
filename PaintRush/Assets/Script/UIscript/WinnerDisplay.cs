using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerDisplay : MonoBehaviour
{
    int GetMax()
    {
        ScoreList.Sort();
        int max = ScoreList[ScoreList.Count - 1];
        return max;
    }
    List<int> ScoreList;
    void Update()
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
        Debug.Log(GetMax());

    }
}
