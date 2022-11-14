using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public int nexSceneLoad;
    public bool fire_move = false;
    [SerializeField] PlayerMove playerMove;

    private void Start()
    {
        playerMove = FindObjectOfType<PlayerMove>();
        nexSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
           
            fire_move = true;
            
            playerMove.animator.SetBool("walk", true);
            playerMove.enabled = false;
            if (nexSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nexSceneLoad);
            }
            
        }
    }

}
