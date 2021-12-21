using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerCollide : MonoBehaviour
{
    Vector3 originalPos;

    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        originalPos = gameObject.transform.position;

    }
    void OnTriggerEnter(Collider other)
    {
        gameObject.transform.position = originalPos;
        if (other.gameObject.tag == "fakeDoor")
        {
            gameObject.transform.position = originalPos;
        }

    }
}
