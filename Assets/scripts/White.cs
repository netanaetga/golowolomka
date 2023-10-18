using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class White : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("pink"))
        {
            rb.isKinematic = false;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.isKinematic = true;
        }
    }
}
