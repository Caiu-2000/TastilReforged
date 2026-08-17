

[System.Serializable]
public class EntitySoundComponent : SoundEmitterComponent
{
    protected Entity parentEntity;


    public override void InitializeThis(Entity ParentEntity= null)
    {
        ParentEntity.OnEntittyAttacked += PlayAttack;
        ParentEntity.OnDeath += PlayDeath;
        ParentEntity.OnDamaged += PlayDamaged;
   
        base.InitializeThis(ParentEntity);
        
        
    }

    public void PlayDamaged()
    {
       
        PlaySound(SoundTypes.Damaged , true);
    }
    public void PlayDeath()
    {
        PlaySound(SoundTypes.Death);
    }
    public void PlayAttack(AttackType type = AttackType.Basic)
    {
        PlaySound(SoundTypes.GenericImpact);
    }
}
