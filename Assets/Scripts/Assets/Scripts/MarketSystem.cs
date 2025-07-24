using System.Collections.Generic;
using UnityEngine;

public class MarketSystem : MonoBehaviour
{
    public List<DrugItem> drugInventory = new List<DrugItem>();

    void Start()
    {
        drugInventory.Add(new DrugItem("Weed", 20f, 10));
        drugInventory.Add(new DrugItem("Coke", 100f, 5));
    }

    public void SellDrug(string name)
    {
        DrugItem drug = drugInventory.Find(d => d.name == name);
        if (drug != null && drug.quantity > 0)
        {
            drug.quantity--;
            Debug.Log($"Sold 1 {drug.name} for ${drug.price}");
        }
    }
}
