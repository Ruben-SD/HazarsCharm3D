using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public string[] tagName;
    public AudioClip clip;
    public float volume=1;

    public void OnCollisionEnter(Collision myCol)
    {
        foreach(string tag in tagName) {
            if (myCol.gameObject.tag == tag) {
                AudioSource.PlayClipAtPoint(clip, transform.position, volume);
                Destroy(myCol.gameObject);
            }
        }
    }
}