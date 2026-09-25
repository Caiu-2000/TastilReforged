public abstract class Weapon : Item
{
    protected float StamCost = 10;


    public abstract void PressedAttack();
    public abstract void ReleasedAttack();

    public abstract void StartSpecial();

    public abstract void StopSpecial();

}