namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private int number;
    private Boolean IsOccupied;
    private ArrayList order = new ArrayList();

    public void Occupy()
    {
        this.IsOccupied = true;
    }

    public void Free()
    {
        this.IsOccupied = false;
        this.order=[];
    }

    public void AddToOrder(Dish plato)
    {
        this.order.Add(plato);
    }

    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
}