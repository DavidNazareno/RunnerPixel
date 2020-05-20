using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
     static int score ;
    int highScore;
    public Text scoreText;
    public Text highScoreText;
	// Use this for initialization
	void Start () {
        Debug.LogError(score);
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
       
        if (score>highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        highScoreText.text = (PlayerPrefs.GetInt("HighScore").ToString());
        scoreText.text=(score.ToString());


      
	}

    public static void ScoreUp()
    {
        score=score+1;
      
    }


    public void ResetScore()
    {
        highScore = 0;
    }

}
