using System.Collections.Generic;

namespace CarList.Models
{
  public class Car
  {
    private int Id;
    private static List<Inventory> _inventory = new List<Inventory> {};

    public Car(int id)
    {
      Id = id;
    }

    public Car(int id, string make, string model, string note, int price, int mileage)
    {
      Id = id;
      Make = make;
      Model = model;
      Price = price;
      Mileage = mileage;
      Note = note;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public string Note { get; set; }
    public int Price { get; set; }
    public int Mileage { get; set; }

    public static List<Inventory> GetAll()
    {
      return _inventory;
    }

    public void Save()
    {
      _inventory.Add(this);
    }

    public static void ClearAll()
    {
      _inventory.Clear();
    }

  }

}
