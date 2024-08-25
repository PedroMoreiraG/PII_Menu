using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private ArrayList assignedTables = new ArrayList();
    private string name;

    public Waiter(string name)
    {
        this.name = name;
    }
    public void AssignTable(Table table)
    {
        this.assignedTables.Add(table);
    }

    public void TakeOrder(Table table, Dish dish)
    {
        table.AddToOrder(dish);
    }
}