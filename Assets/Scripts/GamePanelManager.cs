using UnityEngine;
using TMPro;

public class GamePanelManager : MonoBehaviour
{
    [Header("Scripts")]
    public static GamePanelManager gamePanelManagerScript;

    [Header("Point Values")]
    public int Score;
    public bool enemyHit;

    [Header("Texts")]
    public TMP_Text scoreTxt;

    public void Awake()
    {
        if (gamePanelManagerScript != null && gamePanelManagerScript != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gamePanelManagerScript = this;
        }
    }

    void Start() // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        Score = default;
    }

    void Update() // Update is called once per frame
    {
        scoreTxt.text = $"Score: {Score}";
    }
}
