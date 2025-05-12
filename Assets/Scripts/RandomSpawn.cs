using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSpawn : MonoBehaviour
{
    Vector2 randomPosition;
    public float xRange = 5f;
    public float yRange = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float xPosition = Random.Range(0 - xRange, 0 + xRange);
        float yPosition = Random.Range(1 - yRange, 1 + yRange);
        randomPosition = new Vector2(xPosition, yPosition);
        transform.position = randomPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
}
