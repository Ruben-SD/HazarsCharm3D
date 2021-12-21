using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    bool follow = false;

    float speed;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (follow)
        {
            this.transform.LookAt(player.transform);
            this.GetComponent<Rigidbody>().velocity = this.transform.forward * speed;
        }
    }

    public void Follow(GameObject obj)
    {
        speed = Random.Range(1.0f, 5.0f);
        this.player = obj;
        follow = true;
    }
}
