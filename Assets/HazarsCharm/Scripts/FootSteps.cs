using UnityEngine;

public class FootSteps : MonoBehaviour
{
    public AudioClip clip;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Step()
    {
        Debug.Log("StepEvent called at: " + Time.time);
        audioSource.PlayOneShot(clip);
    }
}
