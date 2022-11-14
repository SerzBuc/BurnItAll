using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public GameObject coin;
    public Transform toAllCoins;
    [SerializeField] SpriteRenderer _renderer;
    public float def_speed;
    public bool coins;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        toAllCoins = GameObject.FindGameObjectWithTag("Score").GetComponent<Transform>();
        
    }

    private void Update()
    {
        if(coins == true)
        {
            _renderer.enabled = true;
            transform.position = Vector3.MoveTowards(transform.position,toAllCoins.position, def_speed);
            if (Vector3.Distance(transform.position, toAllCoins.position) < 0.2f)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            _renderer.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            coins = true;

        }
    }
}
