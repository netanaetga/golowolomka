using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public bool haveKey = false;
    public float speed;
    private Rigidbody phys;
    // Start is called before the first frame update
    void Start()
    {
        phys = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 move = -1 * speed * ((Vector3.forward * v) + (Vector3.right * h));
        move.y = phys.velocity.y;
        phys.velocity = move;

        /*if (Input.GetKey(KeyCode.S))
        {
            phys.velocity=(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            phys.velocity=(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            phys.velocity=(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            phys.velocity=(Vector3.left * speed);
        }*/
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("yell") && haveKey == true)
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;

            Transform key = transform.Find("Key");
            if (key)
            {
                FindObjectOfType<proverka>().yellAct = true;
                Destroy(key.gameObject);
            }
        }
    }
}
