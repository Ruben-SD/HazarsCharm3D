using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public string nameCamera;
    public string nameTarget;

    void Update()
    {
        GameObject rocketCamera;
        rocketCamera = GameObject.Find(nameCamera);
        rocketCamera.transform.LookAt(GameObject.Find(nameTarget).transform);
    }
}
