
using UnityEditor.ShaderGraph.Serialization;

[System.Serializable]
public class HealtComponnent :  ITimable
{

    public float MaxLife;
    public float CurrentLife { get; private set; }

    public bool DamageInCD = false;
    public float DamageCD = 0.2f;
    public HealtComponnent(float max) 
    {
        MaxLife = max;
        CurrentLife = MaxLife;
    }
    public float Damage(float dam , bool IgnoreCD = false)
    {
        CurrentLife -= dam;
        if (!IgnoreCD) 
        {
            DamageInCD = true;
            GameManager.instance.UniversalTimer(DamageCD, this);
        }
        return CurrentLife;
    }

    public void TimeStopped()
    {
        DamageInCD = false;
    }
}
/*
    [SerializeField] protected float _armor = 0f;
    [SerializeField] protected float currentShieldedLife;
    public bool _damCD = false;
    public bool _CanInputMovement = true;

    public float _maxStamina = 100.0f, _currentStamina = 0.0f;
    public float _StaminaCD = 1f , _StaminaCount = 0 , _StaminaRegen = 25f;

    public delegate void HealthChange(float NewHealth, float MaxHealth);
    public HealthChange OnHealthChanged = delegate { };

    public delegate void Damaged(hittData? data = null);
    public Damaged OnDamaged = delegate { };

    public delegate void Dead();
    public delegate void Attack();

    public Dead OnEntityDead = delegate { };
    public Attack OnEntityAttacked = delegate { };

    public delegate void Hittconnected(bool WasCrit = false);
    public Hittconnected OnHittconnected = delegate { };


  

    private void Update()
    {
        if (_StaminaCount > 0) {
            _StaminaCount -= Time.deltaTime;
        }
        else if (_currentStamina < _maxStamina)
        {
            _currentStamina += _StaminaRegen * Time.deltaTime;
            if (_currentStamina > _maxStamina) _currentStamina = _maxStamina;
        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }

 
    public virtual void ReduceStamina(float Cost)
    {
        _currentStamina -= Cost;
        if (_currentStamina <0) _currentStamina = 0;
    }

    public virtual void Heal(float _healAmount)
    {
        _currentLife += _healAmount;
        if (_currentLife > _maxLife) _currentLife = _maxLife;
    }

    public void Hit(float damage = 0, bool ApplyKnockback = false, float knockbackForce = 0, Transform KnockBackFrom = null)
    {
        applyDamage(damage,ApplyKnockback,knockbackForce,KnockBackFrom);
    }
    public void SetShield(float amount)
    {
        currentShieldedLife = amount;
    }
    public void AddArmor(float amount)
    {
        _armor += amount;
    }

    public void RemoveArmor(float amount)
    {
        _armor = Mathf.Max(0, _armor - amount); // can't go below 0
    }
}*/