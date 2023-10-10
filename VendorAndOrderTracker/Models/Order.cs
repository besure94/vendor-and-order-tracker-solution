using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderDescription { get; set ;}
    public int Price { get; set; }
    public int Date { get; set; }

    public Order(string orderTitle, string orderDescription, int price, int date)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      Price = price;
      Date = date;
    }
  }
}