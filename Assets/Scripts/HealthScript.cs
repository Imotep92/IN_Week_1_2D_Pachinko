using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    [Header("Scripts")]
    public static PlayerOrbController playerController;
    public static HealthScript healthScript;

    [Header("Player health variables")]

    public TMP_Text healthTxt;

    public int healthPoints;

    public int maxHealthPoints = 50;


    void Awake()
    {
        if (healthScript != null && healthScript != this)
        {
            Destroy(gameObject);
        }
        else
        {
            healthScript = this;
        }
    }

    void Start() // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        healthPoints = maxHealthPoints;
    }

    void Update() // Update is called once per frame
    {
        healthTxt.text = $"{healthPoints}";
    }

    //void DamageDealt()
    //{
    // healthpoint int - score int
    //}

}
