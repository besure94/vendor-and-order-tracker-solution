using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }

    public Vendor(string name)
    {
      Name = name;
    }
  }
}