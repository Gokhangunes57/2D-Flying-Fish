using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    Text scoreText;
    int highScore;
    public Text PanelHighScore;
    public Text PanelScore;
    public GameObject newPanel;
    
        
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
        PanelScore.text = score.ToString();
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        PanelHighScore.text = highScore.ToString();
        

    }

    public void Scored()
    {
        score++;
        scoreText.text = score.ToString();
        PanelScore.text = score.ToString();
        if (score>highScore)
        {
            highScore = score;
            PanelHighScore.text = highScore.ToString();
            PlayerPrefs.SetInt("HighScore", highScore);
            newPanel.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
