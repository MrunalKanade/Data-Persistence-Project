using UnityEngine;
using TMPro;

public class GameUIHandler : MonoBehaviour
{
    public TMP_Text playerNameText;
    public TMP_Text highScoreText;

    void Start()
    {
        // Show player name
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        if (playerNameText != null)
            playerNameText.text = "Player: " + playerName;

        // Show high score
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        string highScoreName = PlayerPrefs.GetString("HighScoreName", "None");
        if (highScoreText != null)
            highScoreText.text = "Best Score: " + highScoreName + " : " + highScore;
    }

   


    public void CheckHighScore(int score)
    {
        int savedHigh = PlayerPrefs.GetInt("HighScore", 0);

        if (score > savedHigh)
        {
            // Save new high score and player name
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.SetString("HighScoreName", PlayerPrefs.GetString("PlayerName", "Player"));

            // Update UI
            if (highScoreText != null)
                highScoreText.text = "Best Score: " + PlayerPrefs.GetString("PlayerName") + " : " + score;
        }
    }
}
