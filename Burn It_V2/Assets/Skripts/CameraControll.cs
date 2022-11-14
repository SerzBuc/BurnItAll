using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{

    public Transform player;
    public Transform trigger;
    public Finish finish;

    public float offset;

    private void Start()
    {
        finish = FindObjectOfType<Finish>();
    }
    private void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, player.position.z + offset);
        if(finish.fire_move == true)
        {
            transform.position = new Vector3(trigger.position.x, transform.position.y, trigger.position.z);
        }
    }


}
