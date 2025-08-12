using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    [Header("Scripts")]
    public static GameManager gameManagerScript; // Make GameManager script accessible from other scripts
    public static PlayerController playerControllerScript; // Make PlayerController script accessible from other scripts


    [Header("Player position variables")]
    public Rigidbody2D playerOrbRb; // Access to player orb
    private float speed = 0.85f; // Speed of falling player orb
    Vector2 randomPosition; //Vector2 random position variable
    public float xRange = 5f; // xRange coordinates to create xPosition
    float yPosition = -0.5f; // static yPosition

    public void Awake()
    {
        if (playerControllerScript != null && playerControllerScript != this)
        {
            Destroy(gameObject);
        }
        else
        {
            playerControllerScript = this;
        }
    }

    void Start()
    {
        playerOrbRb = GetComponent<Rigidbody2D>();
        
    }


    // Player input for the player orb
    public void PlayerInput()
    {
        // Apply force to Player orb along horizontal axis
        playerOrbRb.AddForce(Vector2.right * Input.GetAxisRaw("Horizontal") * speed);

        if (Input.GetKey(KeyCode.Space))
        {
            RespawnPlayerOrb();
        }
    }

    void RespawnPlayerOrb()
    {
        //only respawn if player object is destroyed

        //pick random xPosition
        float xPosition = Random.Range(-3 - xRange, 8 + xRange);

        // new Vector2 position chosen 
        randomPosition = new Vector2(xPosition, yPosition);

        //place player in a new random position
        transform.position = randomPosition;
    }

    // attack method of the wizard/player
    void MagicSpell()
    {
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // destroy playerorb upon contact with endzones
    }
}

/*  
    cool down for spacebar respawn

    VARIABLES
    public bool isCoolDown;
    private float coolDown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, respawn
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isCoolDown == false)
            {
                RespawnPlayerOrb();
                StartCoroutine(CoolDown());
            }
        }
    }
        //coroutine added, adds cool down for Respawning player orb
        IEnumerator CoolDown( )
    {
        isCoolDown = true;
        yield return new WaitForSeconds(coolDown);
        isCoolDown = false;
    }*/
