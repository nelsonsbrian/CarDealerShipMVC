using System.Collections.Generic;

namespace CarList.Models
{
  public class Car
  {
    private string Id;
    private static List<Car> _inventory = new List<Car> {};

    public Car(string id)
    {
      Id = id;
    }

    public Car(string id, string make, string model, string note, string price, string mileage)
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
    public string Price { get; set; }
    public string Mileage { get; set; }

    public static List<Car> GetAll()
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
