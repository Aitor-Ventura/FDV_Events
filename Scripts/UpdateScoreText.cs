using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateScoreText : MonoBehaviour
{
    private int score = 0;

    public void IncrementScore(int otherScore)
    {
        score += otherScore;
        GetComponent<TextMeshProUGUI>().SetText($"Objects: {score}");
    }
}
