using System.Collections.Generic;

namespace Tracker.Models
{
  public class Order
  {
    public string Title { get; set;}
    public string Description { get; set; }

    public int Price { get; set;}
    public string Date { get; set;}
    public int Id { get; }
    private static List<Order> _orderList = new List<Order> { };
    
    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _orderList.Add(this);
      Id = _orderList.Count;
    }

    public static List<Order> GetAll()
    {
      return _orderList;
    }

    public static void ClearAll()
    {
      _orderList.Clear();
    }

    public static Order Find(int id)
    {
      return _orderList[id -1];
    }
  }
}