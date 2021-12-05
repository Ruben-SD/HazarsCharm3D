using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderGenerator : MonoBehaviour
{
    public Transform boulder = null;

    void Start()
    {

    }

    void Update()
    {
        if (Random.Range(0, 100) == 1)
        {
            Instantiate(boulder, new Vector3(Random.Range(205, 270),
                                            230,
                                            Random.Range(380, 420)),
                                            Quaternion.identity);
        }
    }
}
