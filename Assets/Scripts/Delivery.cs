using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 hasPackageColor = new Color32(0, 0, 0, 255);
    [SerializeField] private Color32 noPackageColor = new Color32(0, 0, 0, 255);
    private bool hasPackage;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch! We hit a " + other.ToString());
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject);
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Delivered to customer!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
