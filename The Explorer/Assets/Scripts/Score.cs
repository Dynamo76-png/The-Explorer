using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;

    public Text scoreText;
    public Text highscoreText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " G";
        highscoreText.text = "Previous Run: " + highscore.ToString();
    }

    public void AddPoint() {
        score += 500;
        scoreText.text = score.ToString() + " G";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
    }
}
