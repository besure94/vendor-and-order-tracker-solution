using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }

    public string OrderDescription { get; set ;}

    public Order(string orderTitle, string orderDescription)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
    }
  }
}