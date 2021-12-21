using System.Linq;
using UnityEngine;

public class BlastOff : MonoBehaviour
{
    public float speed = 0.01f;

    void Update()
    {
        transform.Translate(Vector3.up * speed);
        speed += speed / 300;
    }
}