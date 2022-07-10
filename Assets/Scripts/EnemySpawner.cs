using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefabs;
    [SerializeField] GameObject enemyPrefabs2;
    [SerializeField] GameObject enemyPrefabs3;
    
    [SerializeField] float spawnTime;

    private BoxCollider boxCol;

    [SerializeField] int lineCount;
    [SerializeField] List<Transform> lineList = new List<Transform>();
    
    private Vector2 linePos;

    void Start()
    {
        boxCol = GetComponent<BoxCollider>();
        StartCoroutine("EnemySpawn");
        StartCoroutine("EnemySpawn2");

        linePos = new Vector2(lineList[lineCount].position.x, transform.position.y);


    }

    private void Update()
    {

    }

    IEnumerator EnemySpawn()
    {
        Bounds bounds = boxCol.bounds;

        while (true)
        {
            Vector2 enemyPosition = linePos;
            spawnTime = Random.Range(1, 10);
            Instantiate(enemyPrefabs, new Vector3(transform.position.x, bounds.max.y), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }

    IEnumerator EnemySpawn2()
    {
        Bounds bounds = boxCol.bounds;

        yield return new WaitForSeconds(20);

        while (true)
        {
            Vector2 enemyPosition = linePos;
            spawnTime = Random.Range(10, 20);
            Instantiate(enemyPrefabs2, new Vector3(transform.position.x, bounds.max.y), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }

    
}
