using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GamePanelManager : MonoBehaviour
{
    [Header("Scripts")]
    public static GamePanelManager gamePanelManagerScript;

    [Header("Point Values")]
    public TMP_Text scoreTxt;
    public int Score;

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
        Score = 0;
    }

    void Update() // Update is called once per frame
    {
        scoreTxt.text = $"Score: {Score}";
    }
}
