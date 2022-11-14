using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TNT : MonoBehaviour
{

    [SerializeField] GameMnager gameMnager;
    public Material[] materials;
    public Renderer _renderer;
    [SerializeField] PlayerMove playerMove;
    public GameObject explos;
    public bool coins;
    
   

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.enabled = true;
        _renderer.sharedMaterial = materials[0];
        gameMnager = FindObjectOfType<GameMnager>();
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        
    }

 


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (_renderer.sharedMaterial == materials[0])
            {
                gameMnager.CountKill();

                Instantiate(explos, transform);
            }

            _renderer.sharedMaterial = materials[1];
            playerMove.gas_now = playerMove.gas_Max;
            


        }
    }
  
    
   

}
