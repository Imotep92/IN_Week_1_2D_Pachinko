using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class PlayerOrbController : MonoBehaviour
{
    [Header("Scripts")]
    public static GameManager gameManagerScript;
    public static PlayerOrbController playerOrbScript;
    [HideInInspector] public PlayerStatesList pState;


    [Header("Player position variables")]
    public Rigidbody2D playerOrbRb; // Access to player orb
    public GameObject playerOrbPrefab;
    private float speed = 1f; // Speed of falling player orb
    // Vector2 randomPosition; //Vector2 random position variable

    Vector2 destination;
    Vector2 startingPoint;
    // public float xRange = 5f; // xRange coordinates to create xPosition
    float yPosition = -0.5f; // static yPosition
    float xPosition = 2.5f;



    float minX = -8f;
    float maxX = 13f;
    static float t = 0.0f;


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

        startingPoint = new Vector2(xPosition, yPosition);
        playerOrbRb.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    void Update()
    {

        playerOrbRb.AddForce(Vector2.right * Input.GetAxisRaw("Horizontal") * speed);

        if (Input.GetKey(KeyCode.Space) && pState.isKinematic)
        {
            Debug.Log("space is pressed");
            playerOrbRb.constraints = RigidbodyConstraints2D.None;
            pState.isKinematic = false;
        }
      
    }








    // public void PlayerInput()
    // {
    //     // Apply force to Player orb along horizontal axis
    //     playerOrbRb.AddForce(Vector2.right * Input.GetAxisRaw("Horizontal") * speed);

    //     if (Input.GetKey(KeyCode.Space))
    //     {
    //         RespawnPlayerOrb();
    //     }
    // }



    // attack method of the wizard/player
    // void MagicSpell()
    // {
    // }

    // public void OnTriggerEnter2D(Collider2D collision)
    // {
    //     // destroy playerorb upon contact with endzones
    // }
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
