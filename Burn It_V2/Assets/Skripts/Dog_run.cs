using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_run : MonoBehaviour
{
    
    public float def_speed;
    public bool shoot;

    public Transform player;

    public float directions;
    
   

    public Transform[] movePoints;
    private int currentPoint = 0;
    public Transform target;


    public Animator animator;

    private void Start()
    {
        def_speed = 0.03f;
        
        animator.SetBool("isRun", true);
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void FixedUpdate()
    {

        if (shoot)
        {
            target = player;
            transform.position = Vector3.MoveTowards(transform.position, target.position, def_speed);
            transform.LookAt(target.position);
            if (Vector3.Distance(transform.position, target.position) < 1f)
            {
                def_speed = 0;
                animator.SetBool("isRun", false);

            }
        }
        else
        {
            animator.SetBool("isRun", true);
            target = movePoints[currentPoint].transform;

            transform.position = Vector3.MoveTowards(transform.position, target.position, def_speed);

            transform.LookAt(target.position);


            if (Vector3.Distance(transform.position, target.position) < 1f)
            {
                def_speed = 0;
                animator.SetBool("isRun", false);

            }


        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            shoot = true;
 
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
