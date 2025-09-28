using UnityEngine;
using TMPro;

public class EnemyHealthScript : MonoBehaviour
{
    [Header("Scripts")]
    public static PlayerOrbController playerController;


    [Header("Enemy health variables")]

    public TMP_Text enemyHealthTxt;

    public int enemyHealthPoints;

    public int maxEnemyHealthPoints = 100;

    void Start() // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        enemyHealthPoints = maxEnemyHealthPoints;
    }

    void Update() // Update is called once per frame
    {
        enemyHealthTxt.text = $"{enemyHealthPoints}";


        
    }

        //void DamageDealt()
        //{
        // enemy healthpoint int - score int
        //}

    //  #region Stamina bar variables
    // public Image staminaBar;
    // public float stamina, maxStamina;
    // public float runCost;
    // public bool running;

    // public float chargeRate;
    // private Coroutine recharge;
    // #endregion

    //  #region stamina

    //         //Stamina drains when player is running
    //         if (running/* && is moving */)
    //         {
    //             stamina -= runCost * Time.deltaTime;
    //             if (stamina < 0)
    //             {
    //                 stamina = 0;
    //                 moveSpeed /= runMultiplier;
    //                 running = false;
    //             }
    //             staminaBar.fillAmount = stamina / maxStamina;

    //             if (recharge != null) StopCoroutine(recharge);
    //             recharge = StartCoroutine(RechargeStamina());
    //         }

    //         #endregion stamina

    //  private IEnumerator RechargeStamina()
    // {
    //     yield return new WaitForSeconds(5f);

    //     while (stamina < maxStamina)
    //     {
    //         stamina += chargeRate / 5f;
    //         if (stamina > maxStamina) stamina = maxStamina;
    //         staminaBar.fillAmount = stamina / maxStamina;
    //         yield return new WaitForSeconds(.2f);
}
