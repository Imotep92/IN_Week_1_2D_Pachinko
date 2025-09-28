using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class PlayerOrbController : MonoBehaviour
{
    [Header("Scripts")]
    public static GameManager gameManagerScript;
    public static PlayerOrbController playerOrbScript;
    public static GamePanelManager gamePanelManagerScript;
    [HideInInspector] public PlayerStatesList pState;
    public static PlayerSpawnerScript spawnerScript;
    public static EnemyHealthScript EnemyHealthScript;


    [Header("Player position variables")]
    public Rigidbody2D playerOrbRb; 
    public GameObject playerOrbPrefab;
    private float speed = 1f; 

    public void Awake()
    {
        if (playerOrbScript != null && playerOrbScript != this)
        {
            Destroy(gameObject);
        }
        else
        {
            playerOrbScript = this;
        }
    }

    void Start() // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        pState = GetComponent<PlayerStatesList>();
        playerOrbRb = GetComponent<Rigidbody2D>();
        gamePanelManagerScript = GameObject.Find("Game_Panel").GetComponent<GamePanelManager>();
        EnemyHealthScript = GameObject.Find("Dragon_Health").GetComponent<EnemyHealthScript>();
    }

    void Update() // Update is called once per frame
    {
        playerOrbRb.AddForce(Vector2.right * Input.GetAxisRaw("Horizontal") * speed);
    }

    void OnCollisionEnter2D(Collision2D pointPeg)
    {
        if (pointPeg.gameObject.CompareTag("Peg"))
        {
            gamePanelManagerScript.Score++;
            Debug.Log("+ 1");
        }
    }
        
    void OnTriggerEnter2D(Collider2D Endzone)
    {
        if (Endzone.gameObject.CompareTag("You_Win_Tag"))
        {
            Destroy(gameObject);

            // enemy health script reference for damage dealt

            // game panel script refrence for score to reset
        }
    }
}
