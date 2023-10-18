using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proverka3 : MonoBehaviour
{
    public Collider col;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.parent = other.transform;
            Destroy(col);
            other.gameObject.GetComponent<player>().haveKey = true;
        }
    }

}
