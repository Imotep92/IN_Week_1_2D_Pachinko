using UnityEngine;

public class LerpingRespawnerScript : MonoBehaviour
{
    [Header("Scripts")]
    public static LerpingRespawnerScript lerpingRespawnerScript;


    [Header("Lerping Object variables")]
    private Rigidbody2D spawnerRb;
    float yPosition = -0.5f;
    float minX = -8f;
    float maxX = 13f;
    static float t = 0.0f;

    public void Awake()
    {
        if (lerpingRespawnerScript != null && lerpingRespawnerScript != this)
        {
            Destroy(gameObject);
        }
        else
        {
            lerpingRespawnerScript = this;
        }
    }

    public void Start()
    {
        spawnerRb = GetComponent<Rigidbody2D>();
    }

    public void Update()
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
}
