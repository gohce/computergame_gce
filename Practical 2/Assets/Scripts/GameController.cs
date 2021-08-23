using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI victoryText;
    public TextMeshProUGUI text;
    public GameObject textDisplay;
    public int score = 0;

    public void changeScore(int gemValue)
    {
        score += gemValue;
        text.text = score.ToString();

        if (score >= 100)
        {
            victoryText.text = "Well Done!";
        }

    }
}
