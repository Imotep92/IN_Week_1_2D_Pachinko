using UnityEngine;
using TMPro;

public class EnemyHealthScript : MonoBehaviour
{
    [Header("Scripts")]
    public static GamePanelManager gamePanelManagerScript;

    [Header("Enemy health variables")]
    public int enemyHealthPoints, maxEnemyHealthPoints = 100;

    [Header("Text and Images")]
    public TMP_Text enemyHealthTxt;
    // public Image healthBar;

    void Start() // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        enemyHealthPoints = maxEnemyHealthPoints;

        enemyHealthTxt.text = $"{enemyHealthPoints}";
        gamePanelManagerScript = GameObject.Find("Game_Panel").GetComponent<GamePanelManager>();
    }

    void Update() // Update is called once per frame
    {
        if (enemyHealthPoints > 0)
        {
            DamageDealt();
        }
    }

    void DamageDealt()
    {
        if (gamePanelManagerScript.enemyHit == true)
        {
            enemyHealthTxt.text = $"{enemyHealthPoints -= gamePanelManagerScript.Score}";

            gamePanelManagerScript.Score = default;

            gamePanelManagerScript.enemyHit = false;
        }
        // staminaBar.fillAmount = enemyHealthPoints, maxEnemyHealthPoints;
    }
}
