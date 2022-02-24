using System;
using UnityEngine;

namespace SefIrmak
{
    public class Basket : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Bomb"))
            {
                // add point
                // destroy bomb object
                Destroy(other.gameObject);
            }
        }
    }
}
