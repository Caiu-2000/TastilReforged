using UnityEngine;
using System.Collections.Generic;

public class MobSpawner : MonoBehaviour
{
    [SerializeField] Enemy[] enemies;
    [SerializeField] Transform[] spawnPoints;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int SpawnEnemies()
    {
        int numberOfEnemiesSpawned = 0;
        foreach(Enemy enemy in enemies)
        {
            int randomSpawner = Random.Range(0, spawnPoints.Length);
            Enemy enemySpawned =Instantiate(enemy, spawnPoints[randomSpawner].position, Quaternion.identity);
            numberOfEnemiesSpawned++;
        }
        return numberOfEnemiesSpawned;
    }


}
