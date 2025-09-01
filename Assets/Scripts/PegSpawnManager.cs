using UnityEngine;

public class PegSpawnManager : MonoBehaviour
{
    [Header("Scripts")]
    public static PegSpawnManager pegSpawnManagerScript;


    public Transform[] pegSpawns;  // FIX, turn ARRAY into a LIST
    [SerializeField] GameObject pegPrefab;
    private Vector2 currentSpawn;
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
        




        // TODO: instatiate each peg onto a spawnpoint

        // foreach (Vector2 currentspawn in GetComponent<Transform>)
        // {
        //     Instantiate(pegPrefab, currentSpawn, Quaternion.identity);
        // }


        // currentDestination = _wm.waypoints[Random.Range(0, _wm.waypoints.Length)].position;
    }

    void FixedUpdate()
    {
        currentSpawn = pegSpawnManagerScript.pegSpawns[Random.Range(0, pegSpawnManagerScript.pegSpawns.Length)].position;
        
         Instantiate(pegPrefab, currentSpawn, Quaternion.identity);

        // for (int i = 0; i < 1; i++)
        // {
        //     pegSpawns.RemoveAt(currentSpawn);
        // } FIX, turn ARRAY into a LIST
        
    }

    


    /*
    
void SpawnPointPeg()
{
    for (int)


    for (int i = 0; i < 20; i++)
    {
        Instantiate(pegPrefab, randomPos, Quaternion.identity)
    }
}
*/

}


