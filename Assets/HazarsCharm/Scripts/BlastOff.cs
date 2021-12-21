using System.Linq;
using UnityEngine;

public class BlastOff : MonoBehaviour
{
    public float speed = 0.01f;
    public float maxSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector3.up * speed);
        if(speed <= maxSpeed)
            speed += speed / 300;
    }
}