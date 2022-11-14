using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogZone : MonoBehaviour
{
    [SerializeField] private DogAttack dogAttack;

    private void Start()
    {
        dogAttack = GameObject.FindGameObjectWithTag("Dog").GetComponent<DogAttack>();
        dogAttack.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dogAttack.enabled = true;
        }
    }

   public void StopRun()
    {
        dogAttack.enabled = false;
    }
}
