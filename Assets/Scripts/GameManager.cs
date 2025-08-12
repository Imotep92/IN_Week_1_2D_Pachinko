using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [Header ("Scripts")]
    public static GameManager gameManagerScript { get; private set; }
    public static PlayerController playerControllerScript;
    public static HealthScript healthScript;

    public string transitionedFromScene;


    private void Awake()
    {
        if (gameManagerScript != null && gameManagerScript != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gameManagerScript = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {

    }

    private void Update()
    {
        if (playerControllerScript != null)
        {
            if (SceneManager.GetActiveScene().name == "Game_Over_Screen" ||
                SceneManager.GetActiveScene().name == "Start_Screen") 
            {
                Destroy(playerControllerScript.gameObject);
                playerControllerScript = null;

                if (healthScript != null)
                {
                    Destroy(healthScript.gameObject);
                }

                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
