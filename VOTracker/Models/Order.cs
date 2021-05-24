using System.Collections.Generic;

namespace TrackerApp.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };
    public int Price { get; }
    public string Date { get; set; }

    public Order(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Price = 0;
      Date = "";
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}