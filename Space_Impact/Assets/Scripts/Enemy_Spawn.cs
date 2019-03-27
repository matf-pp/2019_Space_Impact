﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public Rigidbody2D enemy;
    public float moveSpeed = 15.0f;
    public bool changeDirection = false;



    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();

        
    }

    public void moveEnemy()
    {
        if (changeDirection == true)
        {
            enemy.velocity = new Vector2(1, 0) * -1 * moveSpeed;

        }
        else if (changeDirection == false)
            enemy.velocity = new Vector2(-1, 0) *1/6* moveSpeed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Wall3")
            Destroy(this.gameObject);

        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.SetActive(false); 
            Destroy(this.gameObject);
        }
    }
}


