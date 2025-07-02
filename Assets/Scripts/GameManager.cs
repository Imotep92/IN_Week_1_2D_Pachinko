using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Make Playercontrol script accessible from other scripts
    private PlayerController PlayerControllerScript;

    // Access to TitlePanel UI, InfoPanel UI, PausePanel UI, GameOverPanel UI  GameObjects
    [SerializeField] GameObject titlePanel, infoPanel, pausePanel, gameOverPanel; 


    // Is the game in play?
    private bool isGameInPlay = true; 


    //private bool gameIsOver = false;

    
    //private bool playerHasLost = false;

   

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Load the game and title panel
        LoadGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameInPlay)
        {

            //instantiate player health

            //give access to player health script

            //instantiate enemy health

            //give access to enemy health script





            

            // Find the 'PlayerControllerscript' in the 'Player_Orb' Game Object
            PlayerControllerScript = GameObject.Find("Player_Orb").GetComponent<PlayerController>();

            // Find the 'PlayerInput()' within the 'PlayerControllerscript' 
            PlayerControllerScript.PlayerInput();

            
            //pausing the game
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                PauseGame();
            }
        }

        /*
        if(gameIsOver && playerHasLost)
        {
            Debug.log(" You have lost... ");
            isGameInPlay = false
            playerLostPanel.SetActive(true);
            Time.timeScale = 0f;
        } 
        
        else if(gameIsOver && !playerHasLost)
        {
            Debug.log("You won!")
            isGameInPlay = false
            playerWonPanel.SetActive(true);
            Time.timeScale = 0f;
        }*/
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

    public void StartGame()  // BUTTON upon start button press, moves player to the info panel
    {
        // Set Title Panel to false
        titlePanel.gameObject.SetActive(false);

        //Set Info Panel to true
        infoPanel.gameObject.SetActive(true);
    }

    public void PlayGame() // BUTTON Upon pressing 'start game'
    {
        //Has the game started
        isGameInPlay = true;

        //Set Info Panel to true
        infoPanel.gameObject.SetActive(false);

        //Timescale set to 1
        Time.timeScale = 1f;
  
        //instantiate orb with respawn methods in player controller
    }

    void PauseGame() // 'PauseGame' Method
    {
        // Set Title Panel to true
        pausePanel.gameObject.SetActive(true);

        // Timescale set to 0f
        Time.timeScale = 0f;
    }

    public void ResumeGame() // BUTTON 'ResumeGame' Method
    {
        // Set Pause Panel to true
        pausePanel.gameObject.SetActive(false);

        // Timescale set to 0f
        Time.timeScale = 1f; 
    }

    void QuitGame()
    {
        // Debug.log("Quit application")
    }
}
