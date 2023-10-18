using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proverka2 : MonoBehaviour
{
    public bool coscin;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("blue"))
        {
            Destroy(gameObject);
        }
    }


}
