using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionImpulse : MonoBehaviour
{
    public string[] tagName;
    private Rigidbody boulder_Rigidbody;
    public float force = 20f;

    public void OnCollisionEnter(Collision myCol)
    {
        foreach(string tag in tagName) {
            if (myCol.gameObject.tag == tag) {
                if (myCol.gameObject != null) {
                    boulder_Rigidbody = myCol.gameObject.GetComponent<Rigidbody>();
                    boulder_Rigidbody.AddForce(transform.up * force, ForceMode.Impulse);
                }
            }
        }
    }
}
