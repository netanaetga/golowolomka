using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tolchok : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall") || collision.gameObject.CompareTag("wall1"))
        {
            rb.AddForce(collision.contacts[0].normal*4,ForceMode.Impulse);
        }
        
    }
}
