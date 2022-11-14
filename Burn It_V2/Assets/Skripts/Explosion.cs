using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fire_trigger")
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}
