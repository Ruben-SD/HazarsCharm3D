using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnLava : MonoBehaviour
{
    public string[] tagName;
    AudioSource animationSoundPlayer;

    void Start()
    {
        animationSoundPlayer = GetComponent<AudioSource>();
    }

    public void OnCollisionEnter(Collision myCol)
    {
        foreach(string tag in tagName) {
            if (myCol.gameObject.tag == tag) {
                animationSoundPlayer.Play();
                Destroy(this.gameObject);
            }
        }
    }
}