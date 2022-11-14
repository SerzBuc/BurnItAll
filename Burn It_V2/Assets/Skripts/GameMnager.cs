using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMnager : MonoBehaviour
{
    public int Count = 0;
    public Text appleCountText;
    public PlayerMove playerMove;
    public fire_trigger fire_Trigger;
    public GameObject panelPause_Win;
    public GameObject panelPause_Lose;
    public GameObject[] TNT;
    public bool finish;
    public int allCoins;

    private void Start()
    {

        TNT = GameObject.FindGameObjectsWithTag("TNT");
        playerMove = FindObjectOfType<PlayerMove>();
        fire_Trigger = FindObjectOfType<fire_trigger>();
        allCoins = TNT.Length;

       Count = 0;
       appleCountText.text = allCoins.ToString() + ":" + Count.ToString();
    }
    private void Update()
    {

        appleCountText.text = allCoins.ToString() + ":" + Count.ToString();
        PlayerPrefs.SetInt("Score", Count);

        if(Count >= TNT.Length)
        {
            finish = true;
        }

        if(playerMove.hp_now <= 0)
        {
            PauseLoseStart();
        }
        if(playerMove.gas_now <= 0)
        {
            PauseLoseStart();
        }
       
       
    }
    public void CountKill()
    {
        Count++;

    }

    public void PauseWinStart()
    {
        panelPause_Win.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PauseLoseStart()
    {
        panelPause_Lose.SetActive(true);
        
    }

}
