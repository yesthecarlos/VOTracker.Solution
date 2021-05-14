using System.Collections.Generic;
using System;

namespace TrackerApp.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}