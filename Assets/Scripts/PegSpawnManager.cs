using System.Collections.Generic;
using UnityEngine;

public class PegSpawnManager : MonoBehaviour
{
    [Header("Scripts")]
    public static PegSpawnManager pegSpawnManagerScript;


    public List<Transform> pegSpawns;  // FIX, turn ARRAY into a LIST
    [SerializeField] GameObject pegPrefab;
    private Vector2 currentSpawn;

    private int randomIndex;
    public bool hasPeg;



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
     
    }

    void FixedUpdate()  // change method to a separate area as a for loop so when out of spawn points it continues
    {
        randomIndex = Random.Range(0, pegSpawnManagerScript.pegSpawns.Count);

        currentSpawn = pegSpawnManagerScript.pegSpawns[randomIndex].position;

        Instantiate(pegPrefab, currentSpawn, Quaternion.identity);

        pegSpawns.RemoveAt(randomIndex);

        Debug.Log("all pegs spawned");
  
    }

}


