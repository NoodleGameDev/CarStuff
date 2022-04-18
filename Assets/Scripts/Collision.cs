using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch! We hit a " + collision.ToString());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Yoo! We touched a " + collision.ToString());
    }
}
