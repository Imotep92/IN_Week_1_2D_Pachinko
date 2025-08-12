using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [Header("Scripts")]
    public static PlayerController playerController;
    public static HealthScript healthScript;


    void Awake()
    {
        if (healthScript != null && healthScript != this)
        {
            Destroy(gameObject);
        }
        else
        {
            healthScript = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
