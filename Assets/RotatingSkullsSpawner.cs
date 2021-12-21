using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingSkullsSpawner : MonoBehaviour
{
    public GameObject rotatingSkull;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; ++i)
        {
            var pos = transform.position;
            var width = GetComponent<Renderer>().bounds.size.x / 2;
            var depth = GetComponent<Renderer>().bounds.size.z / 2;
            pos.x += Random.Range(-width * 0.9f, width * 0.9f);
            pos.y += 5.0f;
            pos.z += Random.Range(-depth * 0.9f, depth * 0.9f);
            GameObject spawned = Instantiate(rotatingSkull, pos, Quaternion.identity);
            Rigidbody rb = spawned.AddComponent<Rigidbody>();

            rb.angularVelocity = new Vector3(0, 20.0f, 0);
            rb.angularDrag = 0;
            rb.useGravity = false;
            //rb.isKinematic = true;   
        }
    }

    // Update is called once per frame
    void Update()
    {        
    }
}
