using UnityEngine;

public class PlayerOrbController : MonoBehaviour
{
    [Header("Scripts")]
    public static GameManager gameManagerScript;
    public static PlayerOrbController playerOrbScript;
    public static GamePanelManager gamePanelManagerScript;
    [HideInInspector] public PlayerStatesList pState;
    public static PlayerSpawnerScript spawnerScript;
    public static EnemyHealthScript EnemyHealthScript;


    [Header("Player variables")]
    private Rigidbody2D playerOrbRb;
    [HideInInspector] public GameObject playerOrbPrefab;
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
        CallingComponents();

        pState.inPlay = true;
        gamePanelManagerScript.enemyHit = false;
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

    void OnTriggerEnter2D(Collider2D Endzone) //resolve attack method
    {
        if (Endzone.gameObject.CompareTag("You_Win_Tag"))
        {
            gamePanelManagerScript.enemyHit = true;

            Destroy(gameObject);
            pState.inPlay = false;
        }
    }

    void CallingComponents()
    {
        pState = GetComponent<PlayerStatesList>();
        playerOrbRb = GetComponent<Rigidbody2D>();
        gamePanelManagerScript = GameObject.Find("Game_Panel").GetComponent<GamePanelManager>();
        EnemyHealthScript = GameObject.Find("Dragon_Health").GetComponent<EnemyHealthScript>();
    }
}
