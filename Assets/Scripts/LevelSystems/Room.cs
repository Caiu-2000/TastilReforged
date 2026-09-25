using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Room : MonoBehaviour
{
    [SerializeField] List<Room> nextRooms;
    [SerializeField] MobSpawner spawner;
    [SerializeField] float delayUntilMobSpawns;
    List<Enemy> aliveEnemies = new List<Enemy>();
    public void Init(List<Room> rooms)
    {
        foreach (Room room in rooms)
        {
            nextRooms.Add(room);
        }
        SpawnEnemiesDelayed();
    }

    private IEnumerator SpawnEnemiesDelayed()
    {
        yield return new WaitForSeconds(delayUntilMobSpawns);
        aliveEnemies = spawner.SpawnEnemies();
    }
}
