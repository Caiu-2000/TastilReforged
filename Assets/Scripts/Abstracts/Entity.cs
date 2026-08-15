using UnityEngine;

public class Entity : MonoBehaviour , IHittable
{

    [SerializeField] protected HealtComponnent healtComponnent;
   
    public void ApplyHitt(HittData? data = null)
    {
        if (!healtComponnent.DamageInCD) 
        {
            healtComponnent.Damage(data.Damage)
        }
    }


}
