using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Make GameManager script accessible from other scripts
    private static GameManager gameManagerScript;

    // Access to TitlePanel UI GameObject
    public GameObject titlePanel;

    // Access to PausePanel UI GameObject
    public GameObject pausePanel;

    // Access to GameOverPanel UI GameObject
    public GameObject gameOverPanel;

    private Button button;

    // Is the game in play?
    private bool isGameInPlay = true;




    //game is over bool

    //player has won bool

    //player has lost bool

    //pause is active

    //player spawn object

    //score text

    //player health int


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Load the game and title panel
        LoadGame();
    }

    // Update is called once per frame
    void Update()
    {


        //get 'Button' component
        // button = GetComponent<Button>();

        //if start button is clicked, start game 
        // button.onClick.AddListener(StartGame);

        // if the game is paused

        //if the game is over and player has LOST

        // if the game is over the and the player has WON

        // if the application has been quit

    }

    /// <summary>
    /// //////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    public void LoadGame()  // First loading the game
    {
        // Has the game started
        isGameInPlay = false;

        // Set Title Panel to true
        titlePanel.gameObject.SetActive(true);

        //Timescale set to 0
        Time.timeScale = 0f;
    }



    public void StartGame()  // Start game method
    {
        // Has the game started
        isGameInPlay = true;

        // Set Title Panel to false
        titlePanel.gameObject.SetActive(false);

        //Timescale set to 1
        Time.timeScale = 1f;
    }

    void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
        }

        // Get Active pause panel UI true

        // Timescale set to 0f
    }

    void ResumeGame()
    {
        // Get Active pause panel UI false

        // timescale set to 1f
    }

    void QuitGame()
    {
        // Quit application
    }
}
