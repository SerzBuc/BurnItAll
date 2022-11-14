using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfPunch : MonoBehaviour
{
    [SerializeField] PlayerMove playerMove;


    private void Start()
    {
        playerMove = FindObjectOfType<PlayerMove>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerMove.hp_now -= 0.1f;
        }
    }
}