using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpawn : MonoBehaviour
{
    public ParticleSystem gun_shoot;
    public Transform gun;
    [SerializeField] private PlayerMove playerMove;

    private void Start()
    {
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
    }
    public void SpawnShoot()
    {
        Instantiate(gun_shoot, gun);
        playerMove.hp_now -= 0.2f;
    }
}
