using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    private bool hasPackage;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch! We hit a " + other.ToString());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject);
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered to customer!");
            hasPackage = false;
        }
    }
}
