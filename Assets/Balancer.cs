using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balancer : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerStay(Collider other)
    {
    }


    // Update is called once per frame
    void Update()
    {    //{
    //    var player = GameObject.Find("Player");
    //    player.transform.rel
    //    rb.AddTorque(new Vector3(0, 0, 50));
    }
}
