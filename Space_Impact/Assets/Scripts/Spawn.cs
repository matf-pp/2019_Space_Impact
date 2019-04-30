using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public Vector2 center;
    public Vector2 size;


    public float SecondsBetweenSpawn = 3f;
    public float elapsedTime;
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy();
    }
    
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (ScoreScript.scoreValue == 10)// medium mode
            SecondsBetweenSpawn = 2f;
        if (ScoreScript.scoreValue == 20)//hard mode
            SecondsBetweenSpawn = 1.5f; 
        if (elapsedTime > SecondsBetweenSpawn)
        {
            elapsedTime = 0;
            spawnEnemy();
        }

    }

    public void spawnEnemy()
    {

        Vector2 pos = center + new Vector2(15, Random.Range(-size.y / 2, size.y / 2));
        Instantiate(Enemy, pos, Quaternion.identity);
    }


}
