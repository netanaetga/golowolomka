using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnoblak : MonoBehaviour
{
    public GameObject oblaka;
    public float timeforspawn;
    void Start()
    {
        StartCoroutine(spawnoblack());
    }
    void Update()
    {
        
    }
    IEnumerator spawnoblack()
    {
        while (true)
        {
            Instantiate(oblaka, transform);
            yield return new WaitForSeconds(timeforspawn);
        }
    }
}
