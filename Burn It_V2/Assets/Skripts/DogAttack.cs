using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class DogAttack : MonoBehaviour
{
    public float speed;
    [SerializeField] private Transform target_player;
    [SerializeField] private PlayerMove playerMove;
    [SerializeField] private Animator animator;
    [SerializeField] private DogZone dogZone;
    public GameObject home;
    public Transform home_target;
    public bool go_home = true;
    public float def_speed;
   
    

    private void Start()
    {
        target_player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerMove = FindObjectOfType<PlayerMove>();
        dogZone = FindObjectOfType<DogZone>();
        animator = GameObject.FindGameObjectWithTag("Dog_anim").GetComponent<Animator>();
        home_target = home.GetComponent<Transform>();
       
    }
    private void Update()
    {
        if(go_home == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target_player.position, speed);
            transform.LookAt(target_player.position);
            if (Vector3.Distance(transform.position, target_player.position) < 0.1f)
            {
                speed = 0f;
                animator.SetBool("isRun", false);
            }
            else
            {
                speed =def_speed;
                animator.SetBool("isRun", true);
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, home_target.position, speed);
            transform.LookAt(home_target.position);
            if (Vector3.Distance(transform.position, home_target.position) < 1f)
            {
                speed = 0f;
                animator.SetBool("isRun", false);
                dogZone.StopRun();
            }
            else
            {
                speed =def_speed;
                animator.SetBool("isRun", true);
            }
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {          
            go_home = false;
  
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            go_home = true;
            
        }
    }

}
