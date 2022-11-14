using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class EnemyControll : MonoBehaviour
{
    public GameObject shoot_zone;
    public float angle;
    public float def_speed;
    public float rotation_speed;

    public Transform player;
   
    public float directions;
    public float startWaitTime = 0;
    public float waitTime;
    public bool shoot;
    public ParticleSystem gun_shoot;

    public Transform[] movePoints;
    private int currentPoint = 0;
    public Transform target;
   
    
    public Animator animator;

    private void Start()
    {
        def_speed = 0.03f;
        rotation_speed = 0.5f;
        waitTime = startWaitTime;
        animator.SetBool("RunFor", true);
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void FixedUpdate()
    {

        if (shoot)
        {
            animator.SetBool("Shoot", true);
            transform.LookAt(target.position);
        }
        else
        {
            animator.SetBool("Shoot", false);
            target = movePoints[currentPoint].transform;            

            transform.position = Vector3.MoveTowards(transform.position, target.position, def_speed);
            
            transform.LookAt(target.position);

            if (Vector3.Distance(transform.position, movePoints[currentPoint].position) < 0.2f)
            {
                currentPoint++;

                if (currentPoint >= movePoints.Length)
                {
                    currentPoint = 0;
                }
                animator.SetBool("RunFor", true);

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            shoot = true;
           
            target = player;            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            shoot = false;
            target = movePoints[currentPoint].transform;
            
        }
    }
}
