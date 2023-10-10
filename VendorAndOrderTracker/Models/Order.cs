using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set ;}
    public int Price { get; }

    public Order(string orderTitle, string orderDescription, int price)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      Price = price;
    }
  }
}