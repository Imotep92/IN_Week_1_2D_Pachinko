using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScreenScript : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        if (playButton == null || quitButton == null)
        {
            Debug.LogError("Buttons are not assigned in the StartScreen script.");
        }
        else
        {
            playButton.onClick.AddListener(PlayGame);
            quitButton.onClick.AddListener(QuitGame);
        }
    }

    public void PlayGame()
    {
        Debug.Log("Play button clicked");
        SceneManager.LoadScene("Game_Scene");
    }

    public void QuitGame()
    {
        Debug.Log("Quit button clicked");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBGL
        Application.OpenURL(""); //add game link on unity play       
#else
        Application.Quit();
#endif
    }
}
