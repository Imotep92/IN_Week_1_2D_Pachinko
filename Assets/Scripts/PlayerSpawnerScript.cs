using UnityEngine;

public class PlayerSpawnerScript : MonoBehaviour
{
    [Header("Scripts")]
    public static PlayerSpawnerScript SpawnerScript;


    [Header("Player variables")]
    public GameObject playerOrbPrefab;

     public void Awake()
    {
        if (SpawnerScript != null && SpawnerScript != this)
        {
            Destroy(gameObject);
        }
        else
        {
            SpawnerScript = this;
        }
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            Instantiate(playerOrbPrefab, transform.position, Quaternion.identity);
            Debug.Log("space is pressed");
        }
    }
}
