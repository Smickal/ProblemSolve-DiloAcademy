using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public int enemySpawned = 10;
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public static int[] arrayCheckPlace = new int[100] ;
    public static int countEnemy;

    // Start is called before the first frame update
    void Start()
    {
        countEnemy = enemySpawned;
        for(int i = 0; i < enemySpawned; i++)
        {
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            if(arrayCheckPlace[randSpawnPoint] == 0)
            {
                arrayCheckPlace[randSpawnPoint] = 1;
                Debug.Log(randSpawnPoint);
                Instantiate(enemyPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
            }
            else
            {
                i--;
            }

        }
        
    }

    bool isSpawned = false;
    // Update is called once per frame
    void Update()
    {
        if(countEnemy < enemySpawned && isSpawned == false)
        {
            StartCoroutine(AdditionalEnemies());
        }
    }

    private IEnumerator AdditionalEnemies()
    {
        yield return new WaitForSeconds(3);
        for (int i = 0; i < 1; i++)
        {
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            if (arrayCheckPlace[randSpawnPoint] == 0)
            {
                arrayCheckPlace[randSpawnPoint] = 1;
                Debug.Log(randSpawnPoint);
                Instantiate(enemyPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
                countEnemy += 1;
                isSpawned = true;
            }
            else
            {
                i--;
            }

        }
    }
}
