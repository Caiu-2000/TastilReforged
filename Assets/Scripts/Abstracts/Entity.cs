using UnityEngine;

public class Entity : MonoBehaviour , IHittable
{

    [SerializeField] protected HealtComponnent healtComponnent;
    [SerializeField] protected SoundEmitterComponent soundEmitter;

    public delegate void Attack(AttackType type = AttackType.Basic);

    public delegate void Damaged();

    public event Damaged OnDamaged;
    public event Damaged OnDeath;

    public Attack OnEntittyAttacked = delegate { };

    public void ApplyHitt(HittData? data = null)
    {
        if (!healtComponnent.DamageInCD) 
        {
            healtComponnent.Damage(data.Value.Damage);
            OnDamaged?.Invoke();
        }
    }

    public virtual void Die()
    {
        OnDeath?.Invoke();
    }

}
