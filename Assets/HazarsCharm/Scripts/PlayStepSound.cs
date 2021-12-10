using UnityEngine;

public class PlayStepSound : MonoBehaviour
{
    AudioSource animationSoundPlayer;

    void Start()
    {
        animationSoundPlayer = GetComponent<AudioSource>();
    }

    private void Step()
    {
        animationSoundPlayer.Play();
    }
}
