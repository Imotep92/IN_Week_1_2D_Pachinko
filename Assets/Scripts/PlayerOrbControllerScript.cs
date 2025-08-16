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


    [Header("Player position variables")]
    public Rigidbody2D playerOrbRb; // Access to player orb
    public GameObject playerOrb;
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
        else
        {
            LerpingSideToSide(); //try to stop lerping
        }
        

    }


    void LerpingSideToSide()
    {
        transform.position = new Vector2(Mathf.Lerp(minX, maxX, t), yPosition);
        t += 0.5f * Time.deltaTime;

        if (t > 1.0f)
        {
            float temp = maxX;
            maxX = minX;
            minX = temp;
            t = 0.0f;
        }
    }

    void RespawnPlayerOrb()
    {
        //only respawn if player object is destroyed


        // float xPosition = Random.Range(-3 - xRange, 8 + xRange);
        // randomPosition = new Vector2(xPosition, yPosition);
        
        destination = new Vector2(-8, yPosition);
        transform.position = Vector2.Lerp(transform.position, destination, Time.deltaTime * speed);
    }

    void InitialPlayerOrbSpawn()
    {
        
        //transform.position = startingPoint;
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
