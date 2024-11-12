using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        CandyController controller = other.GetComponent<CandyController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}