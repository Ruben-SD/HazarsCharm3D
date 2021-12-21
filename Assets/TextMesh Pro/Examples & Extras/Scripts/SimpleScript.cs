using UnityEngine;
using System.Collections;

    public class WinSound : MonoBehaviour
    {
        AudioSource animationSoundPlayer;

        void Start()
        {
            animationSoundPlayer = GetComponent<AudioSource>();
        }

        private void OnTriggerEnter(Collider other)
        {
            animationSoundPlayer.Play();
        }
    }
