using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    public float spawnRate = 1;

    public GameObject enemy;

    public float leftBound = -5F;
    public float rightBound = 5F;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy() {

        GameObject enemyClone;

        enemyClone = Instantiate(enemy, this.transform.position, this.transform.rotation) as GameObject;

        float x = Random.Range(leftBound, rightBound);
        transform.position = new Vector3(x, this.transform.position.y, 0);
    }
}
