using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform _exitPortalSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Buddy"))
        {
            other.transform.position = _exitPortalSpawn.position;
        }
    }
}
