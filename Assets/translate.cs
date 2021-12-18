using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate : MonoBehaviour
{
    public Vector3 translateVector = new Vector3(0, 3.00f,0);
    public Vector3 stopVector;
    private Vector3 startVector;
    // Start is called before the first frame update
    void Start()
    {
        startVector = transform.position;
        stopVector = startVector + new Vector3(0, 20.00f, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if ((transform.position.x < stopVector.x) && (transform.position.y < stopVector.y) && (transform.position.z < stopVector.z))
        {
            transform.Translate(translateVector.x * Time.deltaTime, translateVector.y * Time.deltaTime, translateVector.z * Time.deltaTime);
        }
        else {
            transform.Translate(-translateVector.x * Time.deltaTime, -translateVector.y * Time.deltaTime, -translateVector.z * Time.deltaTime);
        }
    }
}
