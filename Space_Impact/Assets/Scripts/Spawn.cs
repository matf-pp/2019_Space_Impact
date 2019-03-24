using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public Vector2 center;
    public Vector2 size;


    public float SecondsBetweenSpawn;
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
    private void OnDrawGizmosSelected()
    {
        Gizmos.color=new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);

    }


}
