using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Projectile : MonoBehaviour
{

    public Rigidbody2D projectile;

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(-1, 0) * moveSpeed;
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
            collision.gameObject.SetActive(false);  //unisti igraca kad se sudare
        Destroy(this.gameObject); // unisti projektil kad udari bilo sta

    }
}
