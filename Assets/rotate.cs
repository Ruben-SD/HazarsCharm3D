using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public Vector3 turnVector = new Vector3(0, 0, 10.00f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(turnVector.x * Time.deltaTime, turnVector.y * Time.deltaTime,turnVector.z * Time.deltaTime);
    }
}
