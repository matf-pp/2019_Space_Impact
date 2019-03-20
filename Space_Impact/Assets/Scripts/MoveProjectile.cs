﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    public Rigidbody2D projectile;

    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(1, 0) * moveSpeed; //pomera projektil
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject); // unisti projektil kad udari zid
    }
}
