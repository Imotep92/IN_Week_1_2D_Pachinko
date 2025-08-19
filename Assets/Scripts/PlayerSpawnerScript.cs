using UnityEngine;

public class PlayerSpawnerScript : MonoBehaviour
{
    [Header("Scripts")]
    public static GameManager gameManagerScript;
    public static PlayerOrbController playerOrbScript;
    [HideInInspector] public PlayerStatesList pState;


    [Header("Player position variables")]
    public Rigidbody2D playerOrbRb; // Access to player orb
    public GameObject playerOrbPrefab;
    private float speed = 1f; // Speed of falling player orb
    Vector2 startingPoint;
    float yPosition = -0.5f; // static yPosition
    float xPosition = 2.5f;
    float minX = -8f;
    float maxX = 13f;
    static float t = 0.0f;

    
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
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P is pressed");
            RespawnPlayerOrb();
        }


    }


    void LerpingSideToSide()  //try to stop lerping
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
        Vector2 spawnPosition = new Vector2(xPosition, yPosition);
        Instantiate(playerOrbPrefab, spawnPosition, Quaternion.Euler(0, 0, 0));
    }
    
    // using UnityEngine;

// public class LerpController : MonoBehaviour
// {
//     public Transform startPosition;
//     public Transform endPosition;
//     public float lerpDuration = 2f;
//     private float _lerpTime;
//     private bool _isMoving = true;

//     void Update()
//     {
//         if (_isMoving)
//         {
//             _lerpTime += Time.deltaTime;
//             float t = _lerpTime / lerpDuration;
//             transform.position = Vector3.Lerp(startPosition.position, endPosition.position, t);

//             // Example: Stop Lerp when halfway through
//             if (t >= 0.5f)
//             {
//                 _isMoving = false;
//             }
//         }
//     }

//     // Example function to resume Lerp
//     public void ResumeLerp()
//     {
//         _isMoving = true;
//         // Optionally reset _lerpTime or adjust it based on current position
//     }

}
