using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSpawn : MonoBehaviour
{
    Vector2 randomPosition;
    public float xRange = 5f;
    public float yRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //pick random xPosition
        float xPosition = Random.Range( -3 - xRange, 8 + xRange);

        //static yPosition
        float yPosition = 1f;
       
        // new Vector2 position chosen 
        randomPosition = new Vector2(xPosition, yPosition);

        //place player in new position
        transform.position = randomPosition;
        
    }

    // Update is called once per frame
    void Update()  
    {

        //put this into a restart method
        // put in a cooldown to stop player from spamming the spacebar

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
}
