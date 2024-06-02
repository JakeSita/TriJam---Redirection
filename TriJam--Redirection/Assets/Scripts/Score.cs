using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{

    public TextMeshProUGUI scoretext;

    public void OnEnable()
    {
        StaticGameManager.score += UpdateScoreUI;
    }

    public void OnDisable()
    {
        StaticGameManager.score -= UpdateScoreUI;
    }

    // Start is called before the first frame update
    private void UpdateScoreUI(int score)
    {
        StaticGameManager.Actualscore += score;
        scoretext.SetText("Score: " + StaticGameManager.Actualscore);
    }
}
