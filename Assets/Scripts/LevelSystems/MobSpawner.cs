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
    public List<Enemy> SpawnEnemies()
    {
        List<Enemy> list = new List<Enemy>();
        foreach(Enemy enemy in enemies)
        {
            int randomSpawner = Random.Range(0, spawnPoints.Length);
            Enemy enemySpawned =Instantiate(enemy, spawnPoints[randomSpawner].position, Quaternion.identity);
            list.Add(enemySpawned);
        }
        return list;
    }


}
