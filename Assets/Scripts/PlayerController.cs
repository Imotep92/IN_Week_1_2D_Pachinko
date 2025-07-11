using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{   
    // Make GameManager script accessible from other scripts
    private GameManager gameManagerScript;

    // Access to player orb
    public Rigidbody2D playerOrbRb;

    // Speed of falling player orb
    private float speed = 0.85f;

    //Vector2 random position variable
    Vector2 randomPosition;

    // xRange coordinates to create xPosition
    public float xRange = 5f;

    // static yPosition
    float yPosition = - 0.5f;


    // Player input for the player orb
    public void PlayerInput()
    {
        playerOrbRb = GetComponent<Rigidbody2D>();

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
