using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour
{
    private Rigidbody rb;

    private proverka proverka;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        proverka = GameObject.Find("trigger").GetComponent<proverka>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("white") && proverka.cinact == false)
        {
            proverka.cinact = true;
            rb.isKinematic = false;
        }
    }
}
