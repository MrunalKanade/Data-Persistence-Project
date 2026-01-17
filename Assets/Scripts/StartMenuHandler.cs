using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenuHandler : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void StartGame()
    {
        PlayerPrefs.SetString("PlayerName", nameInput.text);
        SceneManager.LoadScene("Main");
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game pressed");

        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
