using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputRemoting;

public class shipTrigger : MonoBehaviour
{
    ships ship;
    private void Start()
    {
        ship = GetComponentInParent<ships>(); 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ship.speed = 1;
        }
    }
}
