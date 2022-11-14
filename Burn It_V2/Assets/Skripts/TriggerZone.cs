using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    
    public EnemyControll enemyControll;

    private void Start()
    {
        enemyControll = GetComponent<EnemyControll>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            enemyControll.shoot = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            enemyControll.shoot = false;
        }
    }
}
