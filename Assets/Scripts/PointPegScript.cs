using UnityEngine;

public class PointPegScript : MonoBehaviour
{
    [SerializeField] GameObject pegPrefab;
    [SerializeField] int pointValue;
    private Rigidbody2D pegRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pegRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    
     //  TODO: ontriggerevent to destroy self
    //  TODO: point accumulation for player

   

}
