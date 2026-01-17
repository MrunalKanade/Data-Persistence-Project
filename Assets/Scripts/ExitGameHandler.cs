using UnityEngine;

public class ExitGameHandler : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Exit Game clicked");

        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
