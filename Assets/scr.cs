using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
 
 private Plane plane;
    // Start is called before the first frame update
    void Start()
    {
        plane = new Plane(Vector3.back, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
