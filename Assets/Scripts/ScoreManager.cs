using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public GameUIHandler uiHandler; // drag UIHandler here

    void Start()
    {
        score = 0;
    }

    // Call this whenever the player earns points
    public void AddPoint(int points)
    {
        score += points;

        // Update high score if necessary
        if (uiHandler != null)
            uiHandler.CheckHighScore(score);
    }
}
