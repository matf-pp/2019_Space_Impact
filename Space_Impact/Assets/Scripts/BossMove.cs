using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public Rigidbody2D boss;
    public float moveSpeed = 5.0f;
    public bool changeDirection = false;



    // Start is called before the first frame update
    void Start()
    {
        boss = this.gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        moveBoss();


    }

    public void moveBoss()
    {
        if (changeDirection == true)
        {
            boss.velocity = new Vector2(0, 1) * moveSpeed;

        }
        else if (changeDirection == false)
            boss.velocity = new Vector2(0, -1) * moveSpeed ;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Wall1")
        {
            changeDirection = true;
        }
        if (collision.gameObject.name == "Wall2")
        { 
            changeDirection = false;
        }
    }
}