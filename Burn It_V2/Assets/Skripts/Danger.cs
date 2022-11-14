using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    public EnemyControll enemyControll;
    public Renderer _renderer;

    private void Start()
    {
        
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if(enemyControll.shoot == true)
        {
            _renderer.enabled = true;
        }
        else
        {
            _renderer.enabled = false;
        }
    }

}
