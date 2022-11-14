using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody _rigidbody;
    public Joystick joystick;
    public Animator animator;

    public GameObject gas;
    public Image gas_Bar;
    public Image hp_Bar;
   
    public float moveSpeed;
    public float gas_Max = 1;
    public float hp_Max = 1;
    public float gas_now;
    public float hp_now;

    private void Start()
    {
        gas_now = gas_Max;
        hp_now = hp_Max;
        
    }

    private void Update()
    {
        gas_Bar.fillAmount = gas_now;
        hp_Bar.fillAmount = hp_now;
       
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(joystick.Horizontal * moveSpeed, _rigidbody.velocity.y, joystick.Vertical * moveSpeed);

        if(joystick.Horizontal !=0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
   
    public void GasInst()
    {
        if(gas_now >= 0)
        {
            Instantiate(gas, transform.position, transform.rotation);
            gas_now -= 0.01f;
        }
        
    }

}
