public readonly struct EnemyDiedEvent
{
    public int enemyNumber { get; }
    public EnemyDiedEvent(int enemyDeath)
    {
        enemyNumber = enemyDeath;
    }
}
