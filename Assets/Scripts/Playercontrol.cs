using UnityEngine;
using UnityEngine.SceneManagement;



public class Playercontrol : MonoBehaviour
{

    public float speed = 0.75f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

       transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0,0);

       GetComponent<Rigidbody2D>().AddForce(Vector2.right * Input.GetAxis("Horizontal") * speed);
    

    
     
    }
}
