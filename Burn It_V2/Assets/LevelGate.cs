using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGate : MonoBehaviour
{
    [SerializeField] GameMnager gameMnager;

    private void Start()
    {
        gameMnager = FindObjectOfType<GameMnager>();
    }

    private void Update()
    {
        if(gameMnager.finish == true)
        {
            Destroy(gameObject);
        }
    }
}
