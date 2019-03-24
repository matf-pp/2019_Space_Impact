using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform projectileSpawn;
    public GameObject projectile;
    public float nextFire = 1.0f;
    public float currentTime = 0.0f;

    // asdaStart is called before the first frame update
    void Start()
    {
        projectileSpawn = this.gameObject.transform;    
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    public void shoot()
    {
        currentTime += Time.deltaTime;

        if (Input.GetButton("Fire1") && currentTime>nextFire)
        {
            nextFire += currentTime;
            Instantiate(projectile , projectileSpawn.position, Quaternion.AngleAxis(90, Vector3.forward)); //pravi objekat
            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}

