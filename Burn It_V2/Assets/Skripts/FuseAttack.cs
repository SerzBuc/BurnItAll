using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseAttack : MonoBehaviour
{
    public GameObject fuse;
    [SerializeField] private Transform target;
    [SerializeField] private PlayerMove playerMove;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(fuse, target.transform);
            playerMove.hp_now -= 0.2f;
        }
    }
}
