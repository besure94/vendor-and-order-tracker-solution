using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string VendorDescription { get; }

    public Vendor(string name, string vendorDescription)
    {
      Name = name;
      VendorDescription = vendorDescription;
    }
  }
}