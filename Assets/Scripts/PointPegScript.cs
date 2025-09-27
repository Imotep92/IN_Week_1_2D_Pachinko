using UnityEngine;

public class PointPegScript : MonoBehaviour
{
    [SerializeField] GameObject pegPrefab;
    [SerializeField] int pointValue;
    private Rigidbody2D pegRb;

    private 

    // public GameObject playerOrb;

    // playerorb game object

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pegRb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
        //  TODO: ontriggerevent to destroy self
        //  TODO: point accumulation for player
    }

    void OnCollisionEnter2D(Collision2D playerOrb)
    {
        if (playerOrb.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 0.2f);
            Debug.Log("hit!");
            //add +1 point to score to deal dammage e.g.(damage++;)
        }
    }

}
