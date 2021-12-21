using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class OnPlayerCollide : MonoBehaviour
{
    AudioSource animationSoundPlayer;

    void Start()
    {
        animationSoundPlayer = GetComponent<AudioSource>(); 
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fakeDoor")
        {

            animationSoundPlayer.Play();
            SceneManager.LoadScene("SlipperySlope");
        }
        if (other.gameObject.tag == "FinishLine")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
