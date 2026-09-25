
using System.Collections.Generic;

[System.Serializable]
public class HealtComponnent :  ITimable , IObservable<LifeData>
{

    public float MaxLife;
    public float CurrentLife { get; private set; }
    public bool DamageInCD = false;
    public float DamageCD = 0.2f;

    private List<IObserver<LifeData>> Observers = new List<IObserver<LifeData>>();


    public delegate void DamageApplied(float currentLife, float maxLife);
    public DamageApplied OnDamaged = delegate { };

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

    public void Suscribe(IObserver<LifeData> observer)
    {
       Observers.Add(observer);
    }

    public void UnSuscribe(IObserver<LifeData> observer)
    {
        Observers.Remove(observer);
    }
}
public struct LifeData
{
    public float CurrentLife;
    public float MaxLife;

    public LifeData(float max)
    {
        CurrentLife = max;
        MaxLife = max;
    }

}