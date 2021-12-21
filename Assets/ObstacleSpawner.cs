using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawner;
    bool spawnStarted = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Spawner()
    {
        var pos = transform.position;
        var width = GetComponent<Renderer>().bounds.size.x/2;
        var depth = GetComponent<Renderer>().bounds.size.z/2;
        pos.x -= width * 0.85f;
        pos.y += Random.Range(1, 5);
        pos.z += Random.Range(-depth*0.9f, depth*0.9f);
        GameObject shot = Instantiate(bullet, pos, Quaternion.identity);
        shot.AddComponent<Rigidbody>();
        shot.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(width*0.4f, width*0.8f), Random.Range(0, 2), Random.Range(-width/5, width/5));

        Invoke("Spawner", Random.Range(0, 0.5f));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!spawnStarted)
        {
            spawnStarted = true;
            Spawner();
        }
    }

}