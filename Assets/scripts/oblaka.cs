using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oblaka : MonoBehaviour
{
    public float speed;
    public float DistanceDestroy;

    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Vector3.Distance(startPos, transform.position) > DistanceDestroy)
        {
            Destroy(gameObject);
        }
    }
}
