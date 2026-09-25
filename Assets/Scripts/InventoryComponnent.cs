using System;
using UnityEngine;

[System.Serializable]
public class InventoryComponnent 
{

    protected ItemData[] Items;

    [SerializeField]
    protected int InventorySlots = 3;


    public InventoryComponnent(int slots) 
    {
        InventorySlots = slots;
        Items = new ItemData[InventorySlots];
    }

    public void AddItem(Item item) 
    {
        if (item is Weapon)
        {
            // Darsela a la mano de armas
        }
        else
        {
           // Darsela al inventario
        }
    }


}
