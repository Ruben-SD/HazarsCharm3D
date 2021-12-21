using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageIndicator : MonoBehaviour
{
    bool messageShown = false;
    public Text text;
    public EnemiesSpawner spawner;

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
        if (!messageShown)
            ShowMessage();
    }

    void ShowMessage()
    {
        text.enabled = true;
        Invoke("HideMessage", 5);
    }

    void HideMessage()
    {
        text.enabled = false;
    }

    private void OnDestroy()
    {
        spawner.Spawner();
    }
}