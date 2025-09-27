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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthPoints = maxHealthPoints;

        //player bar full health 
    }

    // Update is called once per frame
    void Update()
    {
        //health deduction when player is hurt
    }


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
