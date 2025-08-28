using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerOrbController : MonoBehaviour
{
    [Header("Scripts")]
    public static GameManager gameManagerScript;
    public static PlayerOrbController playerOrbScript;
    [HideInInspector] public PlayerStatesList pState;
    public static PlayerSpawnerScript spawnerScript;


    [Header("Player position variables")]
    public Rigidbody2D playerOrbRb; // Access to player orb
    public GameObject playerOrbPrefab;
    private float speed = 1f; // Speed of falling player orb


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

    void Start()
    {
        pState = GetComponent<PlayerStatesList>();
        playerOrbRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playerOrbRb.AddForce(Vector2.right * Input.GetAxisRaw("Horizontal") * speed);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("You_Win_Tag"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Game_Over_Flame"))
        {
            Destroy(gameObject);
        }
    }
}
