using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public GameObject pivot;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(60.0f, 95.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivot.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
