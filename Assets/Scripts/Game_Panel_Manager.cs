using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GamePanelManager : MonoBehaviour
{
    [Header("Scripts")]
    public static GamePanelManager gamePanelManagerScript;


    public TMP_Text scoreTxt;
    public int Score;


    // public void Awake()
    // {
    //     if (playerOrbScript != null && playerOrbScript != this)
    //     {
    //         Destroy(gameObject);
    //     }
    //     else
    //     {
    //         playerOrbScript = this;
    //     }
    // }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreTxt.text = $"Score:{0}";
    }

    // Update is called once per frame
    void Update()
    {

        // get playerorbscript
        //find score component
        //playerorbscript score will update score value in this script

    }
}
