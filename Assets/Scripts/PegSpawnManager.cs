using System.Collections.Generic;
using UnityEngine;

public class PegSpawnManager : MonoBehaviour
{
    [Header("Scripts")]
    public static PegSpawnManager pegSpawnManagerScript;


    public List<Transform> pegSpawns; 
    [SerializeField] GameObject pegPrefab;
    private Vector2 currentSpawn;
    private bool hasPeg = false;



    void Awake()
    {
        if (pegSpawnManagerScript != null && pegSpawnManagerScript != this)
        {
            Destroy(gameObject);
        }
        else
        {
            pegSpawnManagerScript = this;
        }
    }

    void Start()
    {
        SpawnPegsLoop();
    }

    void FixedUpdate()  
    {
        
    }

    void SpawnPegsLoop()
    {
        if (!hasPeg)
        {
            for (int i = 0; i < pegSpawns.Count; i++)
            {
                currentSpawn = pegSpawns[i].position;
                Instantiate(pegPrefab, currentSpawn, Quaternion.identity);

                hasPeg = true;
            }
        }
        else
        {
            Destroy(pegPrefab);
            hasPeg = false;
            return; 
        }
    }
}
