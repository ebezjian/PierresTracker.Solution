using System.Collections.Generic;

namespace Tracker.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Id { get;}
    private static List<Order> _instances = new List<Order> { };

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public Order(string description)
    {
      // Description = description;
      // _instances.Add(this);
      // Id = _instances.Count;
    }
  }
}