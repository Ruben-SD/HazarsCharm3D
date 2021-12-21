using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWatcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var animators = GetComponentsInChildren<Animator>();

        foreach (Animator animator in animators)
            animator.SetTrigger("Nearing");
    }
}
