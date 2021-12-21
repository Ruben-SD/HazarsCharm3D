using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Vector3 dir;
    public int speed = 3500;

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider bx = this.gameObject.AddComponent<BoxCollider>();
        bx.isTrigger = true;
        
        Rigidbody rb = this.gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
        rb.AddForce(dir.normalized * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            Destroy(collider.gameObject);
            Destroy(this.gameObject);
        }
    }
}
