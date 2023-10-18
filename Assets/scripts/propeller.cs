using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propeller : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(Vector3.left * speed * Time.deltaTime);
    }
}
