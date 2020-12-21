using System.Collections.Generic;

namespace Tracker.Models
{
  public class Vendor
  {
    public string Description {get;set;}
    
    public string Name { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public List<Order> Orders { get; set;} 

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
      
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int id)
    {
      return _instances[id -1];
    }

    public void AddItem(Order order)
    {
      Orders.Add(order);
    }
  }
}