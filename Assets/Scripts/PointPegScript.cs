using UnityEngine;

public class PointPegScript : MonoBehaviour
{
    [SerializeField] GameObject pegPrefab;
    [SerializeField] int pointValue;
    private Rigidbody2D pegRb;
    private int xRange;
    private int yRange;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pegRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private Vector2 RandomSpawnPoint()
    {
        float randomXPosition = Random.Range(-xRange, xRange);
        float randomYPosition = Random.Range(-yRange, yRange);

        Vector2 randomPos = new Vector2(randomXPosition, randomYPosition);

        return randomPos;
    }
    
        /*
        void SpawnPointPeg()
        {
            for (int i = 0; i < 20; i++)
            {
                Instantiate(pegPrefab, randomPos, Quaternion.identity)
            }
        }
        */

}
