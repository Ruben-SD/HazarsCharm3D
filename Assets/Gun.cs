using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    float cooldown = 0.0f;
    float cooldownStart = 0.3f;

    public bool canShoot = false;

    public GameObject bullet;
    public GameObject shootPoint;

    public AudioSource gunShotAudioSource;
    public AudioClip shotSFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot && Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (cooldown <= 0)
            {
                cooldown = cooldownStart;
                Shoot();
                gunShotAudioSource.PlayOneShot(shotSFX, 1);
            }
        }
        cooldown -= Time.deltaTime;
    }

    void Shoot()
    {
        RaycastHit hit;
        Quaternion fireRotation = Quaternion.LookRotation(transform.forward);

        Physics.Raycast(transform.position, Vector3.forward, out hit, Mathf.Infinity);
        
        GameObject tmpBullet = Instantiate(bullet, shootPoint.transform.position, fireRotation);
        BulletMovement moveBullet = tmpBullet.AddComponent<BulletMovement>();
        
        moveBullet.dir = GameObject.FindGameObjectWithTag("MainCamera").transform.forward;
    }
}
