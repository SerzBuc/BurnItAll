using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Start : MonoBehaviour
{
    public GameObject fire;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Fire_trigger")
        {
            Instantiate(fire, transform.position, transform.rotation);
        }
    }
}
