using UnityEngine;

[System.Serializable]
public class DrugItem
{
    public string name;
    public float price;
    public int quantity;

    public DrugItem(string name, float price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }
}
