using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    int enemyCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Spawner()
    {
        ++enemyCounter;
        var pos = transform.position;
        var width = GetComponent<Renderer>().bounds.size.x / 2;
        var depth = GetComponent<Renderer>().bounds.size.z / 2;
        pos.x -= width * 0.85f;
        pos.y += Random.Range(1, 5);
        pos.z += Random.Range(-depth * 0.9f, depth * 0.9f);
        GameObject shot = Instantiate(bullet, pos, Quaternion.identity);
        shot.AddComponent<Rigidbody>();
        shot.tag = "Enemy";
        Follower follower = shot.AddComponent<Follower>();
        follower.Follow(player);

        if (enemyCounter < 30)
            Invoke("Spawner", Random.Range(0.3f, 3.0f));
    }
}
