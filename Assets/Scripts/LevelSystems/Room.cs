using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Room : MonoBehaviour, IInteractable
{
    [SerializeField] List<Room> nextRooms;
    [SerializeField] MobSpawner spawner;
    [SerializeField] float delayUntilMobSpawns;
    int aliveEnemies = 0;

    public string Message => "Go To Next Room";

    private void OnEnable()
    {
        EventManager<GameEvent>.Subscribe<EnemyDiedEvent>(GameEvent.EnemyKilled, OnEnemyDeath);
    }
    private void OnDisable()
    {
        
    }
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
        int aliveEnemies = spawner.SpawnEnemies();
    }
    private void OnEnemyDeath(EnemyDiedEvent data)
    {
        aliveEnemies--;
    }

    public void Interact()
    {
        if(aliveEnemies <= 0)
        {

        }
    }
}
